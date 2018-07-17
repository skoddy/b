using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Windows.Forms;

namespace Quiz
{
    public class MySQLDatabase : IDatabase
    {
        DbConnection dbConnection;
        DBConfig _config;

        public MySQLDatabase(DBConfig config)
        {
            _config = config;
            Connect();
        }

        public void Connect()
        {
            try
            {
                dbConnection = new MySqlConnection(_config.ConnectionString);
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Create<T>(string table, T obj)
        {
            IDbCommand cmd = dbConnection.CreateCommand();

            cmd.CommandText = GenerateSqlCommandFromObject("INSERT INTO", table, obj);
            cmd.ExecuteNonQuery();
        }

        public void Delete(string table, int id)
        {
            IDbCommand cmd = dbConnection.CreateCommand();

            cmd.CommandText = $"DELETE from {table} WHERE Id={id}";
            cmd.ExecuteNonQuery();

        }

        public List<T> CreateListFromTable<T>(string table, string opt = "") where T : IPopulateData, new()
        {
            T type;

            List<T> list = new List<T>();

  
            DbDataReader reader = SqlStatement($"SELECT * FROM {table} {opt}");

            if (reader != null)
            {
                while (reader.Read())
                {
                    type = new T();
                    type.PopulateData(reader);
                    list.Add(type);
                }
                reader.Close();
            }

            return list;
        }

        public T ReadOne<T>(string q, string opt = "") where T : IPopulateData, new()
        {
            T type = new T();

            DbDataReader reader = SqlStatement($"SELECT * FROM {q} {opt}");

            while (reader.Read())
                type.PopulateData(reader);

            reader.Close();

            return type;
        }

        public void Update<T>(string table, T obj)
        {
            IDbCommand cmd = dbConnection.CreateCommand();

            cmd.CommandText = GenerateSqlCommandFromObject("UPDATE", table, obj);
            cmd.ExecuteNonQuery();
        }

        public void Disconnect()
        {
            dbConnection.Close();
        }

        ~MySQLDatabase()
        {
            Disconnect();
        }

       

        private string GenerateSqlCommandFromObject<T>(string action, string table, T obj)
        {
            string command = $"{action} {table} SET ";
            int id = 0;
            // Objekttyp bestimmen und alle Eigenschaften einlesen.
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            // Anzahl der Objekt Eigenschaften und ein Zähler um zu bestimmen,
            // wann die letzte Eigenschaft gelesen wurde, damit an dem Command String
            // entweder ein Komma oder ein Lehrzeichen angefügt werden kann.
            int length = properties.Length;
            int i = 1;

            // Einzelne Eigenschaften auslesen.
            foreach (PropertyInfo property in properties)
            {
                string propertyName = property.Name;

                // Da wir hier wissen welche Eigenschaften der Typ hat,
                // können wir diese gezielt aus dem als Parameter übergebenden Objekt
                // auslesen.
                object propertyValue = property.GetValue(obj, null);
                string propertyType = property.PropertyType.Name;

                // Die Eigenschaft "Id" wird speziell behandelt.
                // Wenn die Id == 0 ist, wird die Eigenschaft als NULL
                // in die Datenbank geschrieben um die auto_increment funktion
                // von MySQL auszulösen.
                // Ansonsten wird ein neuer Eintrag mit festgelegter Id erstellt.
                if (propertyName == "Id")
                {
                    command += (int)propertyValue == 0 ? $"{propertyName} = NULL, " : $"{propertyName} = {propertyValue}, ";
                    id = (int)propertyValue;
                    i++;
                    continue;
                }

                // Hier sollte die Prüfung folgen, ob die Eigenschaft einen Wert hat.
                // Wenn eine Klasse mehrere Konstruktoren hat, führt eine Undefinierte Eigenschaft zu fehlern.
                // FUNKTIONIERT ABER NICHT :D
                // TODO: propertyValue auf Wert prüfen...
                if (typeof(T).GetProperty(property.Name) != null)
                {
                    // Unterscheidung der Eigenschaftstypen. Ein String wird mit,
                    // und ein Integer ohne Hochkomma dem Command String hinzugefügt.
                    switch (propertyType)
                    {
                        case "Int32":
                            command += $"{propertyName} = {propertyValue}";
                            break;
                        case "String":
                            command += $"{propertyName} = '{propertyValue}'";
                            break;
                        case "DateTime":
                            DateTime date = Convert.ToDateTime(propertyValue);
                            string MySQLDate = date.ToString("yyyy-MM-dd");
                            command += $"{propertyName} = '{MySQLDate}'";
                            break;
                        case "Boolean":
                            command += $"{propertyName} = {propertyValue}";
                            break;
                    }

                    // Sind alle Eigenschaften ausgelesen?
                    command += (length == i) ? " " : ", ";
                    i++;
                }
            }

            command += (action == "UPDATE") ? $"WHERE Id={id}" : "";
            command += ";";

            return command;
        }

        public DbDataReader SqlStatement(string q)
        {
            DbCommand cmd = dbConnection.CreateCommand();
            DbDataReader reader = null;
            cmd.CommandText = q;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler!");
            }

            return reader;
        }

    }
}

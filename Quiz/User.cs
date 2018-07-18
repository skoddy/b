using System.Data.Common;
using Quiz.Extensions;

namespace Quiz
{
    public class User : IPopulateData
    {

        public int Id { get; set; }
        public string Display_Name { get; set; }
        public string Password { get; set; }
        private MySQLDatabase _db;

        // Parameterloser Kontruktor 
        public User() { }

        public User(MySQLDatabase db)
        {
            _db = db;
        }

        public User(int id, string display_name, string password)
        {
            Id = id;
            Display_Name = display_name;
            Password = password;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Display_Name = dataReader.GetString(1);
            Password = dataReader.GetString(2);
        }

        public void Create()
        {
            Password = Password.CryptString();

            _db.Create("user", this);
        }

        public bool Login(string display_name, string password)
        {
            bool authed = false;

            User user = _db.ReadOne<User>($"user", $"WHERE Display_Name = '{display_name}'");

            if (user.Password == password.CryptString())
            {
                authed = true;
                Id = user.Id;
                Display_Name = user.Display_Name;
            }

            return authed;
        }

        public User Get(int id)
        {
           return _db.ReadOne<User>($"user", $"WHERE Id = '{id}'");
        }
    }
}

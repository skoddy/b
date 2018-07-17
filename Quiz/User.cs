using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class User : IPopulateData
    {

        public int Id { get; set; }
        public string Display_Name { get; set; }
        public string Password { get; set; }

        // Parameterloser Kontruktor 
        public User() { }

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
    }
}

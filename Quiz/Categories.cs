using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Categories : IPopulateData
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Categories(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Name = dataReader.GetString(1);
        }
    }
}

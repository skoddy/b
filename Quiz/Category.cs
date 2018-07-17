using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Category : IPopulateData
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Category() { }

        public Category(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Text = dataReader.GetString(1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question : IPopulateData
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string FileName { get; set; }
        public int Category_id { get; set; }

        public Question() { }

        public Question(int id, string text, string fileName, int category_id)
        {
            Id = id;
            Text = text;
            FileName = fileName;
            Category_id = category_id;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Text = dataReader.GetString(1);
            FileName = dataReader.GetString(2);
            Category_id = dataReader.GetInt32(3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Questions : IPopulateData
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string FileName { get; set; }
        public int Category_id { get; set; }
        public int Answer_id { get; set; }

        public Questions() { }

        public Questions(int id, string question, string fileName, int category_id, int answer_id)
        {
            Id = id;
            Question = question;
            FileName = fileName;
            Category_id = category_id;
            Answer_id = answer_id;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Question = dataReader.GetString(1);
            FileName = dataReader.GetString(2);
            Category_id = dataReader.GetInt32(3);
            Answer_id = dataReader.GetInt32(4);
        }
    }
}

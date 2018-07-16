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
        public int Category_id { get; set; }
        public int Answer_id { get; set; }

        public Questions(int id, string question, int category_id, int answer_id)
        {
            Id = id;
            Question = question;
            Category_id = category_id;
            Answer_id = answer_id;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Question = dataReader.GetString(1);
            Category_id = dataReader.GetInt32(2);
            Answer_id = dataReader.GetInt32(3);
        }
    }
}

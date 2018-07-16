using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Answers : IPopulateData
    {
        public int Id { get; set; }
        public string Answer { get; set; }

        public Answers(int id, string answer)
        {
            Id = id;
            Answer = answer;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Answer = dataReader.GetString(1);
        }
    }
}

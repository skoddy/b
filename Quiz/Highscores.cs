using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Highscores : IPopulateData
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int User_id { get; set; }
        public int Score { get; set; }

        public Highscores(int id, DateTime createdAt, int user_id, int score)
        {
            Id = id;
            CreatedAt = createdAt;
            User_id = user_id;
            Score = score;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            CreatedAt = dataReader.GetDateTime(1);
            User_id = dataReader.GetInt32(2);
            Score = dataReader.GetInt32(3);
        }
    }
}

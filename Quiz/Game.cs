using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public class Game
    {
        public string Category { get; set; } 
        public RadioButton AnswerOne { get; set; }
        private MySQLDatabase _db;
        public Game(string category, MySQLDatabase db)
        {
            Category = category;
            _db = db;
        }

        public void getQuestions()
        {

        }
    }
}

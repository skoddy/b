using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Game
    {
        public string Category { get; set; }
        public int QuestionId { get; set; }
        public int QuestionNumber { get; set; }
        public int MaxQuestions { get; set; }
        public int Score { get; set; }

        private MySQLDatabase _db;
        private Category _c;


        public Game(string category, MySQLDatabase db, int maxQuestions = 3)
        {
            Category = category;
            QuestionId = 0;
            QuestionNumber = 1;
            MaxQuestions = maxQuestions;
            Score = 0;
            _db = db;
            _c = _db.ReadOne<Category>("categories", $"WHERE Text = '{Category}'");
        }

        public List<Question> GetQuestions()
        {
            return _db.CreateListFromTable<Question>("questions", $"WHERE Category_id = {_c.Id} ORDER BY RAND() LIMIT 10");
        }

        public List<Answer> GetAnswers(int question_id)
        {
            // Liste mit 3 zufälligen Antworten erstellen und die richtige Antwort ausschliessen.
            List<Answer> answers = _db.CreateListFromTable<Answer>("answers", $"WHERE Question_id = {question_id} ORDER BY RAND()");

            return answers;
        }

        public Answer GetCorrectAnswer(int id)
        {
            return _db.ReadOne<Answer>("answers", $"WHERE Question_id = {id} AND State = true");
        }
    }
}

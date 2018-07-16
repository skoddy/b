using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz.Extensions;

namespace Quiz
{
    public class Game
    {
        public string Category { get; set; } 
        public RadioButton AnswerOne { get; set; }
        private MySQLDatabase _db;
        Random gen = new Random();
        public Game(string category, MySQLDatabase db)
        {
            Category = category;
            _db = db;
        }

        public void getQuestasdions()
        {
            Categories c = _db.ReadOne<Categories>("categories", $"WHERE Name = '{Category}'");

            List<Questions> questions = _db.CreateListFromTable<Questions>("questions", $"WHERE Category_id = {c.Id} LIMIT 10");

            foreach (Questions question in questions)
            {
                // Liste mit 3 zufälligen Antworten erstellen und die richtige Antwort ausschliessen.
                List<Answers> answers = _db.CreateListFromTable<Answers>("answers", $"WHERE Category_id = {c.Id} AND Id !={question.Answer_id} ORDER BY RAND() LIMIT 3");

                MessageBox.Show(question.Question);
                // Die richtige Antwort holen
                Answers correctAnswer = _db.ReadOne<Answers>("answers", $"WHERE Category_id = {c.Id} AND Id ={question.Answer_id}");

                // Die richtige Antwort mit Insert in die Liste der Anworten hinzufügen.
                // list.Add() würde die richtige Antwort immer ans Ende der Liste schreiben
                // und ist somit ungeeignet.
                // Mit zufälligeAntworten.Insert(position, richtige Antwort) kann ich die Antwort an eine bestimmte Position schreiben.
                // Mit gen.Next(0,4) erzeuge ich eine zufällige Zahl zwischen 0 und 3. 
                // Damit ist die richtige Antwort immer an einer anderen Position.

                answers.Insert(gen.Next(0,4), correctAnswer);

                foreach (Answers answer in answers)
                {
                    MessageBox.Show(gen.Next(0, 4).ToString());
                    MessageBox.Show(answer.Answer);
                }
            }
        }

        public List<Questions> getQuestions()
        {
            Categories c = _db.ReadOne<Categories>("categories", $"WHERE Name = '{Category}'");

            return _db.CreateListFromTable<Questions>("questions", $"WHERE Category_id = {c.Id} ORDER BY RAND() LIMIT 10");
        }

        public List<Answers> GetAnswers(int answer_id)
        {
            Categories c = _db.ReadOne<Categories>("categories", $"WHERE Name = '{Category}'");

            // Liste mit 3 zufälligen Antworten erstellen und die richtige Antwort ausschliessen.
            List<Answers> answers = _db.CreateListFromTable<Answers>("answers", $"WHERE Category_id = {c.Id} AND Id != {answer_id} ORDER BY RAND() LIMIT 3");

            // Die richtige Antwort holen
            Answers correctAnswer = _db.ReadOne<Answers>("answers", $"WHERE Category_id = {c.Id} AND Id = {answer_id}");

            // Die richtige Antwort mit Insert in die Liste der Anworten hinzufügen.
            // list.Add() würde die richtige Antwort immer ans Ende der Liste schreiben
            // und ist somit ungeeignet.
            // Mit zufälligeAntworten.Insert(position, richtige Antwort) kann ich die Antwort an eine bestimmte Position schreiben.
            // Mit gen.Next(0,4) erzeuge ich eine zufällige Zahl zwischen 0 und 3. 
            // Damit ist die richtige Antwort immer an einer anderen Position.
            answers.Insert(gen.Next(0, 4), correctAnswer);

            return answers;
        }
    }
}

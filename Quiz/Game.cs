using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Game
    {
        public string Category { get; set; } 

        private MySQLDatabase _db;
        private Categories _c;

        public Game(string category, MySQLDatabase db)
        {
            Category = category;
            _db = db;
            _c = _db.ReadOne<Categories>("categories", $"WHERE Name = '{Category}'");
        }

        public List<Questions> GetQuestions()
        {
            return _db.CreateListFromTable<Questions>("questions", $"WHERE Category_id = {_c.Id} ORDER BY RAND() LIMIT 10");
        }

        public List<Answers> GetAnswers(int answer_id)
        {
            // Liste mit 3 zufälligen Antworten erstellen und die richtige Antwort ausschliessen.
            List<Answers> answers = _db.CreateListFromTable<Answers>("answers", $"WHERE Category_id = {_c.Id} AND Id != {answer_id} ORDER BY RAND() LIMIT 3");

            // Die richtige Antwort holen
            Answers correctAnswer = GetCorrectAnswer(answer_id);

            // Die richtige Antwort mit Insert in die Liste der Anworten hinzufügen.
            // list.Add() würde die richtige Antwort immer ans Ende der Liste schreiben
            // und ist somit ungeeignet.
            // Mit zufälligeAntworten.Insert(position, richtige Antwort) kann ich die Antwort an eine bestimmte Position schreiben.
            // Mit gen.Next(0,4) erzeuge ich eine zufällige Zahl zwischen 0 und 3. 
            // Damit ist die richtige Antwort immer an einer anderen Position.
            Random gen = new Random();
            answers.Insert(gen.Next(0, 4), correctAnswer);

            return answers;
        }

        public Answers GetCorrectAnswer(int answer_id)
        {
            return _db.ReadOne<Answers>("answers", $"WHERE Category_id = {_c.Id} AND Id = {answer_id}");
        }
    }
}

using System.Data.Common;

namespace Quiz
{
    public class Answer : IPopulateData
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool State { get; set; }
        public int Question_id { get; set; }
        public string FileName { get; set; }

        public Answer() { }

        public Answer(int id, string text, bool state, int question_id, string fileName = "")
        {
            Id = id;
            Text = text;
            State = state;
            Question_id = question_id;
            FileName = fileName;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Text = dataReader.GetString(1);
            State = dataReader.GetBoolean(2);
            Question_id = dataReader.GetInt32(3);
            FileName = dataReader.GetString(4);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Admin : Form
    {
        MySQLDatabase _db;
        List<Category> listCategories;
        List<Answer> listAnswers;
        List<Question> listQuestions;
        public Admin(MySQLDatabase db)
        {
            _db = db;
            InitializeComponent();
            
            fillCatLB();
            createAnswerGroup();
        }
       
        private void fillCatLB()
        {
            listCategories = _db.CreateListFromTable<Category>("categories");
            lbCat.Items.Clear();
            foreach (Category item in listCategories)
            {
                lbCat.Items.Add(item.Text);
            }
        }

        private void fillQuestionsLB()
        {
            int index = lbCat.SelectedIndex;
            int catId = listCategories[index].Id;
            listQuestions = _db.CreateListFromTable<Question>("questions", $"WHERE Category_id = {catId}");
            lbQuestions.Items.Clear();
            foreach (Question item in listQuestions)
            {
                lbQuestions.Items.Add(item.Text);
            }
        }

        private void btnDelCat_Click(object sender, EventArgs e)
        {
            int index = lbCat.SelectedIndex;
            _db.Delete("categories", listCategories[index].Id);
            fillCatLB();
        }

        private void btnNewCat_Click(object sender, EventArgs e)
        {
            _db.Create("categories", new Category(0, tbNewCat.Text));
            tbNewCat.Text = "";
            fillCatLB();
        }

        private void lbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillQuestionsLB();
            createAnswerGroup();
        }

        private void btnSaveNewQuestion_Click(object sender, EventArgs e)
        {
            int catIndex = lbCat.SelectedIndex;
            int catId = listCategories[catIndex].Id;

            _db.Create("questions", new Question(0, tbNewQuestion.Text, "", catId));

            DbDataReader reader = _db.SqlStatement("SELECT LAST_INSERT_ID()");
            reader.Read();
            int lastId = reader.GetInt32(0);
            reader.Close();

            int i = 1;

            RadioButton rbCorrectAnswer = grpTextAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            int correctAnswerId = Convert.ToInt32(rbCorrectAnswer.Text);

            foreach(TextBox tb in grpTextAnswers.Controls.OfType<TextBox>())
            {
                if (i == correctAnswerId)
                {
                    _db.Create("answers", new Answer(0, tb.Text, true, lastId));
                }
                else
                {
                    _db.Create("answers", new Answer(0, tb.Text, false, lastId));
                }
                i++;
            }

            fillQuestionsLB();
            createAnswerGroup();
        }

        private void lbQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int questionIndex = lbQuestions.SelectedIndex;
            int questionId = listQuestions[questionIndex].Id;

            tbNewQuestion.Text = listQuestions[questionIndex].Text;
            listAnswers = _db.CreateListFromTable<Answer>("answers", $"WHERE Question_id = {questionId}");

            grpTextAnswers.Controls.Clear();

            int radionButtonY = 20;
            int number = 1;
            foreach (Answer answer in listAnswers)
            {
                RadioButton rb = new RadioButton
                {
                    Name = $"rb{answer.Id}",
                    Text = number.ToString(),
                    Location = new Point(11, radionButtonY),
                    AutoSize = true,
                    Checked = answer.State
                };

                TextBox tb = new TextBox
                {
                    Name = $"tb{answer.Id}",
                    Text = answer.Text,
                    Location = new Point(48, radionButtonY),
                    Width = 354
                };

                grpTextAnswers.Controls.AddRange(new Control[] { rb, tb });
                radionButtonY += 27;
                number++;
            }
        }

        private void createAnswerGroup()
        {
            grpTextAnswers.Controls.Clear();
            tbNewQuestion.Text = "";
            int radionButtonY = 20;
            int number = 1;
            for (int i = 0; i <= 3; i++)
            {
                RadioButton rb = new RadioButton
                {
                    Name = $"rb{number}",
                    Text = number.ToString(),
                    Location = new Point(11, radionButtonY),
                    AutoSize = true,
                    Checked = false
                };

                TextBox tb = new TextBox
                {
                    Name = $"tb{number}",
                    Text = "",
                    Location = new Point(48, radionButtonY),
                    Width = 354
                };

                grpTextAnswers.Controls.AddRange(new Control[] { rb, tb });
                radionButtonY += 27;
                number++;
            }
        }
    }
}

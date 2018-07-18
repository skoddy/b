using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.IO;
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
            createTextAnswerGroup();
        }

        private void btnSaveNewQuestion_Click(object sender, EventArgs e)
        {
            int catIndex = lbCat.SelectedIndex;
            int catId = listCategories[catIndex].Id;
            string questionFileName = "";
            if (pbQuestionImage.Tag != null)
            {
                questionFileName = Path.GetFileName(pbQuestionImage.Tag.ToString());
                questionFileName = questionFileName != null ? (DateTime.Now.ToString("yyyyMMddhhmm") + questionFileName) : "";
            }


            _db.Create("questions", new Question(0, tbNewQuestion.Text, questionFileName, catId));

            DbDataReader reader = _db.SqlStatement("SELECT LAST_INSERT_ID()");
            reader.Read();
            int lastId = reader.GetInt32(0);
            reader.Close();

            int i = 1;

            RadioButton rbCorrectAnswer = grpTextAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            RadioButton rbAnswerType = grpAnswerType.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            List<PictureBox> pbAnswerPicures = 
                new List<PictureBox>(grpTextAnswers.Controls.OfType<PictureBox>());
            int correctAnswerId = Convert.ToInt32(rbCorrectAnswer.Text);

            foreach(TextBox tb in grpTextAnswers.Controls.OfType<TextBox>())
            {
                string anwerFileName = "";

                if (pbAnswerPicures.Count() != 0)
                {
                    anwerFileName = Path.GetFileName(pbAnswerPicures[i - 1].Tag.ToString());
                    anwerFileName = anwerFileName != null ? (DateTime.Now.ToString("yyyyMMddhhmm") + anwerFileName) : "";

                    try
                    {
                        if (pbQuestionImage.Image != null)
                        {
                            pbAnswerPicures[i - 1].Image.Save(@"c:\quiz\" + anwerFileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was a problem saving the file." +
                            "Check the file permissions.");
                        MessageBox.Show(ex.ToString());
                    }
                }

                if (i == correctAnswerId)
                {
                    _db.Create("answers", new Answer(0, tb.Text, true, lastId, anwerFileName));
                }
                else
                {
                    _db.Create("answers", new Answer(0, tb.Text, false, lastId, anwerFileName));
                }

                i++;
            }
            try
            {
                if (pbQuestionImage.Image != null)
                {
                    pbQuestionImage.Image.Save(@"c:\quiz\" + questionFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
                MessageBox.Show(ex.ToString());
            }

            pbQuestionImage.Image = null;
            fillQuestionsLB();
            createTextAnswerGroup();
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

        private void createTextAnswerGroup()
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

        private void createPictureAnswerGroup()
        {
            grpTextAnswers.Controls.Clear();
            grpTextAnswers.AutoSize = true;
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

                PictureBox pb = new PictureBox
                {
                    Name = $"pb{number}",
                    Location = new Point(48, radionButtonY -10),
                    BorderStyle = BorderStyle.None
                };

                Button btn = new Button
                {
                    Name = $"btn{number}",
                    Location = new Point(300, radionButtonY),
                    Text = "Bild"
                };

                btn.Click += (s, e) => {

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pb.Load(openFileDialog1.FileName);
                        pb.Tag = openFileDialog1.FileName;
                    }

                };

                grpTextAnswers.Controls.AddRange(new Control[] { rb, pb, btn });
                radionButtonY += 60;
                number++;
            }
        }

        private void chooseAnswerPicture1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbQuestionImage.Load(openFileDialog1.FileName);
                pbQuestionImage.Tag = openFileDialog1.FileName;
            }
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbQuestionImage.Load(openFileDialog1.FileName);
                pbQuestionImage.Tag = openFileDialog1.FileName;
            }
        }

        private void rbAnswerTypeText_Click(object sender, EventArgs e)
        {
            createTextAnswerGroup();
        }

        private void rbAnswerTypePicture_Click(object sender, EventArgs e)
        {
            createPictureAnswerGroup();
        }
    }
}

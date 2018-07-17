using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private MySQLDatabase _db;

        private User _user;
        private Game _game;
        private Auth _auth;

        private List<Question> listQuestions;
        private List<Answer> listAnswers;

        private Question question;

        private bool authed = false;

        public Form1()
        {
            _db = new MySQLDatabase(new DBConfig());
            _user = new User(_db);
            _auth = new Auth(_db);
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            _user.Display_Name = tbDisplayName.Text;
            _user.Password = tbPassword.Text;
            authed = _auth.Login(tbDisplayName.Text, tbPassword.Text);

            if (authed)
            {
                MessageBox.Show("Willkommen!");
                panLogin.Visible = false;
                panChooseCategory.Visible = true;
            }
            else
            {
                MessageBox.Show("Name oder Passwort falsch!");
            }
        }

        private void btnSignUp_Click(object sender, System.EventArgs e)
        {
            if (tbDisplayName.Text.Length < 3 || tbPassword.Text.Length < 3)
            {
                MessageBox.Show("Name und Passwort muss mindestens 3 Zeichen lang sein.");
            }
            else
            {
                _user.Id = 0;
                _user.Display_Name = tbDisplayName.Text;
                _user.Password = tbPassword.Text;
                _user.Create();
            }
        }

        private void btnGameStart_Click(object sender, System.EventArgs e)
        {
            // Überprüfung ob und welcher RadioButton gewählt wurde.
            RadioButton gameCategory = grpGameMode.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (gameCategory != null)
            {
                panChooseCategory.Visible = false;
                InitGame(gameCategory.Text);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst eine Kategorie.");
            }
        }

        private void InitGame(string gameCategory)
        {
            panGame.Visible = true;
            
            _game = new Game(gameCategory, _db);
            listQuestions = _game.GetQuestions();

            ShowQuestion();
        }

        private void ShowQuestion()
        {
            grpAnswers.Controls.Clear();
            pbQuestion.Visible = false;
            btnNextQuestion.Enabled = false;
            btnAnswer.Enabled = true;
            lblResult.Text = "";
            int radionButtonY = 15;

            question = listQuestions[_game.QuestionId];

            lblQuestion.Text = question.Text;
            lblQuestionNumber.Text = _game.QuestionNumber.ToString();
            lblMaxQuestions.Text = _game.MaxQuestions.ToString();

            if (question.FileName != "")
            {
                pbQuestion.Visible = true;
                pbQuestion.ImageLocation = $"files\\flags\\{question.FileName}";
            }
            listAnswers = _game.GetAnswers(question.Id);

            foreach (Answer answer in listAnswers)
            {
                RadioButton rb = new RadioButton
                {
                    Name = $"rb{answer.Text}",
                    Text = answer.Text,
                    Location = new Point(10, radionButtonY)
                };

                grpAnswers.Controls.Add(rb);
                radionButtonY += 20;
            }
            
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            panGame.Visible = false;
            panChooseCategory.Visible = true;
            lblScore.Text = "0";
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            _game.QuestionId++;
            _game.QuestionNumber++;
            btnAnswer.Focus();
            ShowQuestion();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            RadioButton answered = grpAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            Answer correctAnswer = _game.GetCorrectAnswer(question.Id);

            if (answered != null)
            {
                if (answered.Text == correctAnswer.Text)
                {
                    lblResult.Text = "Richtig!";
                    lblResult.ForeColor = Color.Green;
                    _game.Score += 10;
                    lblScore.Text = _game.Score.ToString();
                }
                else
                {
                    lblResult.Text = "Falsch.";
                    lblResult.ForeColor = Color.Red;
                }

                btnNextQuestion.Enabled = _game.QuestionNumber < _game.MaxQuestions ? true : false;
                btnNextQuestion.Focus();
                btnResult.Enabled = _game.QuestionNumber == _game.MaxQuestions ? true : false;
                btnResult.Focus();
                btnCancel.Enabled = _game.QuestionNumber == _game.MaxQuestions ? false : true;
                btnAnswer.Enabled = false;
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(_db);
            admin.Show();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

        }
    }
}

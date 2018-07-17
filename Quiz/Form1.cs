using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private MySQLDatabase db;
        private User user;
        private Game game;
        private List<Question> questions;
        Question question;
        private List<Answer> answers;
        private Auth auth;

        private bool authed = false;


        public Form1()
        {
            db = new MySQLDatabase(new DBConfig());
            user = new User();
            InitializeComponent();
            auth = new Auth(db);
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            user.Display_Name = tbDisplayName.Text;
            user.Password = tbPassword.Text;
            authed = auth.Login(tbDisplayName.Text, tbPassword.Text);

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
                user.Id = 0;
                user.Display_Name = tbDisplayName.Text;
                user.Password = tbPassword.Text;
                auth.CreateUser(user);
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
            
            game = new Game(gameCategory, db);
            questions = game.GetQuestions();

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

            question = questions[game.QuestionId];

            lblQuestion.Text = question.Text;
            lblQuestionNumber.Text = game.QuestionNumber.ToString();
            if (question.FileName != "")
            {
                pbQuestion.Visible = true;
                pbQuestion.ImageLocation = $"files\\flags\\{question.FileName}";
            }
            answers = game.GetAnswers(question.Id);

            foreach (Answer answer in answers)
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
            game.QuestionId++;
            game.QuestionNumber++;
            ShowQuestion();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            RadioButton answered = grpAnswers.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            Answer correctAnswer = game.GetCorrectAnswer(question.Id);

            if (answered != null)
            {
                if (answered.Text == correctAnswer.Text)
                {
                    lblResult.Text = "Richtig!";
                    game.Score += 10;
                    lblScore.Text = game.Score.ToString();
                }
                else
                {
                    lblResult.Text = "Falsch.";
                }

                btnNextQuestion.Enabled = true;
                btnAnswer.Enabled = false;
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(db);
            admin.Show();
        }
    }
}

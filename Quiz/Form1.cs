using System.Windows.Forms;
using Quiz.Extensions;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace Quiz
{
    public partial class Form1 : Form
    {
        MySQLDatabase db;
        User user;
        Game game;
        List<Questions> questions;
        List<Answers> answers;
        Answers correctAnswer;
        bool authed = false;
        int questionId;
        int questionNumber;
        int score;

        public Form1()
        {
            db = new MySQLDatabase(new DBConfig());
            user = new User();
            InitializeComponent();
        }



        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            user.Display_Name = tbDisplayName.Text;
            user.Password = tbPassword.Text;

            authed = Auth.Login(user, db);

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

                Auth.CreateUser(user, db);
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
            score = 0;
            questionId = 0;
            questionNumber = 1;
            game = new Game(gameCategory, db);

            questions = game.GetQuestions();

            ShowQuestion();

        }

        private void ShowQuestion()
        {
            grpAnswers.Controls.Clear();

            int radionButtonY = 15;

            Questions question = questions[questionId];

            lblQuestion.Text = question.Question;
            lblQuestionNumber.Text = questionNumber.ToString();

            answers = game.GetAnswers(question.Answer_id);

            correctAnswer = game.GetCorrectAnswer(question.Answer_id);

            foreach (Answers answer in answers)
            {
                RadioButton rb = new RadioButton
                {
                    Name = $"rb{answer.Answer}",
                    Text = answer.Answer,
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
            questionId++;
            questionNumber++;
            ShowQuestion();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            RadioButton answered = grpAnswers.Controls.OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);
            if (answered != null)
            {
                if (answered.Text == correctAnswer.Answer)
                {
                    lblResult.Text = "Richtig!";
                    score += 10;
                    lblScore.Text = score.ToString();
                }
                else
                {
                    lblResult.Text = "Falsch.";
                }
            }

        }
    }
}

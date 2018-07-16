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
        User user = new User();
        Game game;
        bool authed = false;

        public Form1()
        {
            db = new MySQLDatabase(new DBConfig());
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
            user.Id = 0;
            user.Display_Name = tbDisplayName.Text;
            user.Password = tbPassword.Text;

            Auth.CreateUser(user, db);
        }

        private void btnGameStart_Click(object sender, System.EventArgs e)
        {
            // Überprüfung ob und welcher RadioButton gewählt wurde.

            RadioButton gameCategory = grpGameMode.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (gameCategory != null)
            {
                panChooseCategory.Visible = false;
                StartGame(gameCategory.Text);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst eine Kategorie.");
            }
        }

        private void StartGame(string gameCategory)
        {
            grpAnswers.Controls.Clear();
            panGame.Visible = true;

            game = new Game(gameCategory, db);

            List<Questions> questions = game.getQuestions();

            int radionButtonY = 15;
            int questionId = 0;

            Questions question = questions[questionId];

            lblQuestion.Text = question.Question;
            lblQuestionNumber.Text = (questionId + 1).ToString();

            List<Answers> answers = game.GetAnswers(question.Answer_id);

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
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}

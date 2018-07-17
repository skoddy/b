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
            // Name und Passwort einlesen
            _user.Display_Name = tbDisplayName.Text;
            _user.Password = tbPassword.Text;

            // Eigebene Daten mit Daten aus der Datenbank vergleichen.
            // Sind die Daten vorhanden gibt _auth.Login() true zurück.
            authed = _auth.Login(tbDisplayName.Text, tbPassword.Text);

            // Wenn Benutzerdaten in der Datenbank gefunden worden sind
            if (authed)
            {
                // Begrüßung ;)
                MessageBox.Show("Willkommen!");

                // Login Panel verstecken
                panLogin.Visible = false;

                // Kategorie Panel anzeigen
                panChooseCategory.Visible = true;
            }
            else
            {
                // Sind die Benutzerdaten nicht gefunden worden,
                // ist entweder der Name oder das Passwort falsch.
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
                // Wenn die eingegebenen Daten eine mindestlänge von 3 Zeichen haben,
                // werden diese in der class User() gespeichert
                _user.Id = 0;
                _user.Display_Name = tbDisplayName.Text;
                _user.Password = tbPassword.Text;

                // und ein neuer Benutzer erstellt.
                _user.Create();
            }
        }

        private void btnGameStart_Click(object sender, System.EventArgs e)
        {
            // Überprüfung ob und welche Kategorie gewählt wurde.
            RadioButton gameCategory = grpGameMode.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (gameCategory != null)
            {
                // Kategorie Panel verbergen
                panChooseCategory.Visible = false;

                // Spiel mit gewählter Kategorie initialisieren
                InitGame(gameCategory.Text);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst eine Kategorie.");
            }
        }

        private void InitGame(string gameCategory)
        {
            // Spiel Panel anzeigen
            panGame.Visible = true;
            
            // Spiel mit gewählter Kategorie und initialisierter Datenbank starten
            _game = new Game(gameCategory, _db);

            // Fragen holen
            listQuestions = _game.GetQuestions();

            // Fragen anzeigen
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            /* Panel vorbereiten */

            // Alle Elemente aus der GroupBox entfernen
            grpAnswers.Controls.Clear();

            // Y Startposition der RadioButtons festlegen
            int radionButtonY = 15;

            // PictureBox verstecken
            pbQuestion.Visible = false;

            // Buttons aktivieren und deaktivieren
            btnNextQuestion.Enabled = false;
            btnAnswer.Enabled = true;

            // Text aus dem Ergebnislabel entfernen
            lblResult.Text = "";

            /* Panel füllen */

            // Aktuelle Frage holen
            question = listQuestions[_game.QuestionId];

            // Frage anzeigen
            lblQuestion.Text = question.Text;

            // Laufende Fragen Nummer anzeigen
            lblQuestionNumber.Text = _game.QuestionNumber.ToString();

            // Maximale Fragenanzahl anzeigen
            lblMaxQuestions.Text = _game.MaxQuestions.ToString();

            // Überprüfen ob die Frage ein Bild hat und anzeigen
            if (question.FileName != "")
            {
                pbQuestion.Visible = true;
                pbQuestion.ImageLocation = $"files\\flags\\{question.FileName}";
            }

            // Antworten zur Frage holen
            listAnswers = _game.GetAnswers(question.Id);

            // GroupBox mit den Anworten füllen
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

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

        private List<Question> listQuestions;
        private List<Answer> listAnswers;
        private List<Category> listCategories;
        private List<Highscores> listHighscores;

        private Question question;

        private bool authed = false;

        public Form1()
        {
            _db = new MySQLDatabase(new DBConfig());
            _user = new User(_db);
            InitializeComponent();
            ShowAuth();
        }

        private void ShowAuth()
        {
            HidePanels();
            panAuth.Visible = true;
        }

        private void ShowCategories()
        {
            panChooseCategory.Visible = true;
            listCategories = _db.CreateListFromTable<Category>("categories");
            grpChooseCategory.AutoSize = true;

            int radionButtonY = 15;
            foreach (Category category in listCategories)
            {
                RadioButton rb = new RadioButton
                {
                    Name = "rb" + category.Id,
                    Text = category.Text,
                    Location = new Point(10, radionButtonY)

                };

                radionButtonY += 20;
                grpChooseCategory.Controls.Add(rb);
            }
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
                pbQuestion.ImageLocation = @"c:\quiz\" + question.FileName;
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

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            // Name und Passwort einlesen
            _user.Display_Name = tbDisplayName.Text;
            _user.Password = tbPassword.Text;

            // Eigebene Daten mit Daten aus der Datenbank vergleichen.
            // Sind die Daten vorhanden gibt _auth.Login() true zurück.
            authed = _user.Login(tbDisplayName.Text, tbPassword.Text);

            // Wenn Benutzerdaten in der Datenbank gefunden worden sind
            if (authed)
            {
                // Begrüßung ;)
                MessageBox.Show($"Willkommen {_user.Display_Name}!");

                // Login Panel verstecken
                panAuth.Visible = false;

                // Auswahl Kategorie 
                ShowCategories();
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
            RadioButton gameCategory = grpChooseCategory.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (gameCategory != null)
            {
                // Kategorie Panel verbergen
                HidePanels();

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

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            HidePanels();
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
                if (_game.QuestionNumber == _game.MaxQuestions)
                {
                    _db.Create("highscores", new Highscores(0, DateTime.Now, _user.Id, _game.Score));
                    btnHighScores.Focus();
                }
                btnHighScores.Enabled = _game.QuestionNumber == _game.MaxQuestions ? true : false;
                btnCancel.Enabled = _game.QuestionNumber == _game.MaxQuestions ? false : true;
                btnAnswer.Enabled = false;
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(_db);
            admin.Show();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            ShowHighscores();

        }

        private void ShowHighscores()
        {
            Highscores highscores = new Highscores(_db);
            HidePanels();
            panHighScores.Visible = true;
            listHighscores = highscores.GetList();
            int i = 1;
            int lblStartPositionY = 57;

            foreach (Highscores highscore in listHighscores)
            {

                Label lblRank = new Label
                {
                    Name = "lblRank" + highscore.Id.ToString(),
                    Text = i.ToString(),
                    Location = new Point(23, lblStartPositionY),
                    AutoSize = true
                };

                Label lblDate = new Label
                {
                    Name = "lblDate" + highscore.Id.ToString(),
                    Text = highscore.CreatedAt.ToString("dd.MM.yyyy"),
                    Location = new Point(156, lblStartPositionY),
                    AutoSize = true
                };

                Label lblName = new Label
                {
                    Name = "lblName" + highscore.Id.ToString(),
                    Text = _user.Get(highscore.User_id).Display_Name,
                    Location = new Point(88, lblStartPositionY),
                    AutoSize = true
                };

                Label lblScore = new Label
                {
                    Name = "lblScore" + highscore.Id.ToString(),
                    Text = highscore.Score.ToString(),
                    Location = new Point(239, lblStartPositionY),
                    AutoSize = true
                };
                lblStartPositionY += 20;
                i++;
                grpHighscores.Controls.AddRange(new Control[] { lblRank, lblName, lblDate, lblScore });
            }
        }

        private void HidePanels()
        {
            List<Panel> panels = new List<Panel>(this.Controls.OfType<Panel>());

            foreach (Panel panel in panels)
            {
                panel.Visible = false;
            }
        }
    }
}

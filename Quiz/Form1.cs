using System.Windows.Forms;
using Quiz.Extensions;
using System.Linq;

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

            var gameCategory = grpGameMode.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (gameCategory != null)
            {
                panChooseCategory.Visible = false;
                game = new Game(gameCategory.Text, db);
                panGame.Visible = true;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst eine Kategorie.");
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {

        }
    }
}

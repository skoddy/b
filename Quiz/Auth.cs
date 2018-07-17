using Quiz.Extensions;

namespace Quiz
{
    public class Auth
    {
        MySQLDatabase _db;

        public Auth(MySQLDatabase db)
        {
            _db = db;
        }

        public void CreateUser(User user)
        {
            user.Password = user.Password.CryptString();
            
            _db.Create("user", user);
        }

        public bool Login(string display_name, string password)
        {
            bool authed = false;

            User user = _db.ReadOne<User>($"user", $"WHERE Display_Name = '{display_name}'");

            if (user.Password == password.CryptString())
            {
                authed = true;
            }

            return authed;
        }

    }
}

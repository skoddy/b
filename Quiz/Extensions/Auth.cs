using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.Extensions
{
    public static class Auth
    {


        public static void CreateUser (User user, IDatabase db)
        {
            db.Create("user", user);
        }

        public static bool Login(User user, IDatabase db)
        {
            bool authed = false;

            User u = db.ReadOne<User>($"user WHERE Display_Name = '{user.Display_Name}'");

            if (u.Password == user.Password)
            {
                authed = true;
            }

            return authed;
        }

        public static string cryptPassword(this string password)
        {
            byte xorConstant = 0x53;
            byte[] data = Encoding.UTF8.GetBytes(password);

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)(data[i] ^ xorConstant);
            }

            string output = Convert.ToBase64String(data);

            return output;
        }

        public static string encryptPassword(this string password)
        {
            byte xorConstant = 0x53;
            byte[] data = Convert.FromBase64String(password);

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)(data[i] ^ xorConstant);
            }

            string plain = Encoding.UTF8.GetString(data);

            return plain;
        }
    }
}

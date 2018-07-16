using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Extensions
{
    public static class Crypt
    {
        public static string CryptString(this string str)
        {
            byte xorConstant = 0x53;
            byte[] data = Encoding.UTF8.GetBytes(str);

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)(data[i] ^ xorConstant);
            }

            string ret = Convert.ToBase64String(data);

            return ret;
        }

        public static string EncryptString(this string str)
        {
            byte xorConstant = 0x53;
            byte[] data = Convert.FromBase64String(str);

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)(data[i] ^ xorConstant);
            }

            string ret = Encoding.UTF8.GetString(data);

            return ret;
        }
    }
}

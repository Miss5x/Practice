using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication
{
    public class Generetion
    {
        public static string GetKod(int length)
        {
            Random random = new Random();
            string kod = null;
            for (int i = 0; i < length; i++)
            {
                kod += random.Next(0, 10);
            }
            return kod;
        }
        public static string GetSalt(int length)
        {
            RNGCryptoServiceProvider p = new RNGCryptoServiceProvider();
            var salt = new byte[length];
            p.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }
        public static string GetSHA1(string kod, string salt)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(Encoding.UTF8.GetBytes(kod + salt));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();
            foreach (byte b in re)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}

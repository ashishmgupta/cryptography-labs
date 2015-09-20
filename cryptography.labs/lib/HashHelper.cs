using System;
using System.Security.Cryptography;
using System.Text;

namespace lib
{
    public class HashHelper
    {
        public static string GetMD5Hash(string message)
        {
            using (var md5 = MD5.Create())
            {
                byte[] hashedBytes = md5.ComputeHash(Encoding.Unicode.GetBytes(message));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public static string GetSHA1Hash(string message)
        {
            using (var sha1 = SHA1.Create())
            {
                byte[] hashedBytes = sha1.ComputeHash(Encoding.Unicode.GetBytes(message));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public static string GetSHA256Hash(string message)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.Unicode.GetBytes(message));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public static string GetSHA512Hash(string message)
        {
            using (var sha512 = SHA512.Create())
            {
                byte[] hashedBytes = sha512.ComputeHash(Encoding.Unicode.GetBytes(message));
                return Convert.ToBase64String(hashedBytes);
            }
        }

    }
}

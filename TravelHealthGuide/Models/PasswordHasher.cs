using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TravelHealthGuide.Models
{
    public static class PasswordHasher
    {
        public static string Hash(string rawString)
        {
            byte[] bytes;
            using (SHA256 hasher = SHA256.Create())
            {
                bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(rawString));
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                stringBuilder.Append(b.ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}

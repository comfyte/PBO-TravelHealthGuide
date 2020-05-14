using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using TravelHealthGuide.Models.DatabaseModels;
using TravelHealthGuide.Views;

namespace TravelHealthGuide.Models
{
    public class AdminLoginModel
    {
        public bool Authenticate(string Username, string RawPassword)
        {
            string HashedPassword = PasswordHasher.Hash(RawPassword);

            int match;
            using (var db = new DataBase())
            {
                match = db.Users
                    .Where(u => u.Username == Username && u.HashedPassword == HashedPassword)
                    .Count();
            }
            if (match > 0)
            {
                return true;
            }
            return false;
        }
    }
}

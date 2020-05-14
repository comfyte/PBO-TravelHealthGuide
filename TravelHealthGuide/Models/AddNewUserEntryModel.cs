using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.Models
{
    public class AddNewUserEntryModel
    {
        public bool CreateUser(string username, string rawPassword)
        {
            string hashedPassword = PasswordHasher.Hash(rawPassword);

            using (var db = new DataBase())
            {
                // Check if username already exists on database
                int AlreadyExists = db.Users
                    .Where(u => u.Username == username)
                    .Count();
                if (AlreadyExists > 0)
                {
                    return false;
                }

                // If above check passes, proceed to create new user
                db.Add(new UserInfo
                {
                    Username = username,
                    HashedPassword = hashedPassword
                });
                db.SaveChanges();
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.Models
{
    public class ChangeUserPasswordModel
    {
        private string _username;
        public ChangeUserPasswordModel(string username)
        {
            _username = username;
        }
        public int ChangePassword(string Old, string New, string ConfirmNew)
        {
            string HashedOld = PasswordHasher.Hash(Old);
            string HashedNew = PasswordHasher.Hash(New);
            string HashedConfirmNew = PasswordHasher.Hash(ConfirmNew);

            using (var db = new DataBase())
            {
                UserInfo user = db.Users.Where(u => u.Username == _username).First();

                if (user.HashedPassword != HashedOld)
                {
                    return 1;
                }

                if (String.IsNullOrEmpty(New))
                {
                    return 2;
                }

                if (HashedNew != HashedConfirmNew)
                {
                    return 3;
                }

                user.HashedPassword = HashedNew;
                db.SaveChanges();
            }
            return 0;
        }
    }
}

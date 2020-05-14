using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.Models
{
    public class RemoveUserEntryModel
    {
        public bool RemoveUser(UserInfo user)
        {
            using (var db = new DataBase())
            {
                // Cek jumlah user agar masih ada setidaknya satu user yang tersisa
                if (db.Users.Count() <= 1)
                {
                    return false;
                }

                db.Remove(user);
                db.SaveChanges();
            }
            return true;
        }
    }
}

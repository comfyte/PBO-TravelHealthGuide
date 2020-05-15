using System;
using System.Collections.Generic;
using System.Text;

namespace TravelHealthGuide.Models.DatabaseModels.Seeds
{
    public class UsersSeed
    {
        public List<UserInfo> Items { get; }

        public UsersSeed()
        {
            this.Items = new List<UserInfo>
            {
                new UserInfo
                {
                    UserID = 1,
                    Username = "admin",
                    HashedPassword = PasswordHasher.Hash("admin")
                }
            };
        }
    }
}

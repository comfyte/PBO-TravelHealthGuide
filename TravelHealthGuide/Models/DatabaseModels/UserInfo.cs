using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelHealthGuide.Models.DatabaseModels
{
    public class UserInfo
    {
        [Key]
        public int UserID { get; set; }

        public string Username { get; set; }
        public string HashedPassword { get; set; }
    }
}

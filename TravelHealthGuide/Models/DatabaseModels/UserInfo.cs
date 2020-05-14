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

        [Required]
        public string Username { get; set; }
        [Required]
        public string HashedPassword { get; set; }
    }
}

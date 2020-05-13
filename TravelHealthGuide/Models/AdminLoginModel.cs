using System;
using System.Collections.Generic;
using System.Text;
using TravelHealthGuide.Views;

namespace TravelHealthGuide.Models
{
    class AdminLoginModel
    {
        public bool Authenticate(string Username, string Password)
        {
            if (Username == "a" && Password == "a")
            {
                return true;
            }
            return false;
        }
    }
}

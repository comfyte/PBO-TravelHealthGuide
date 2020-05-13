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
            if (Username == "comfyte" && Password == "cfy")
            {
                return true;
            }
            return false;
        }
    }
}

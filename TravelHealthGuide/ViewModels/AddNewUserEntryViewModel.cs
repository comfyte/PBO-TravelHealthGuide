using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models;

namespace TravelHealthGuide.ViewModels
{
    public class AddNewUserEntryViewModel
    {
        private readonly AddNewUserEntryModel _model;

        public string Username { get; set; }

        public AddNewUserEntryViewModel()
        {
            _model = new AddNewUserEntryModel();
        }

        public bool CreateUser(string Password)
        {
            if (String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Field cannot be blank!", "Error");
                return false;
            }

            if (!_model.CreateUser(Username, Password))
            {
                MessageBox.Show("Username already exists!", "Error");
                return false;
            }

            return true;
        }
    }
}

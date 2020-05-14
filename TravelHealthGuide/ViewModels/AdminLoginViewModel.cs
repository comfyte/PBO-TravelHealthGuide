using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models;

namespace TravelHealthGuide.ViewModels
{
    public class AdminLoginViewModel
    {
        private readonly AdminLoginModel _model;

        public string Username { private get; set; }

        public AdminLoginViewModel()
        {
            _model = new AdminLoginModel();
        }

        public bool Authenticate(string Password)
        {
            bool isAuthenticated = _model.Authenticate(Username, Password);
            if (isAuthenticated)
            {
                Views.AdminOptionsWindow w = new Views.AdminOptionsWindow(Username);
                w.Owner = Application.Current.MainWindow;
                w.Show();
                return true;
            }
            MessageBox.Show("Invalid username or password", "Could not authenticate", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
    }
}

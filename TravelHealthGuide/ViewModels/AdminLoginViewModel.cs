using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models;

namespace TravelHealthGuide.ViewModels
{
    class AdminLoginViewModel
    {
        private readonly AdminLoginModel _model;

        public string Username { get; set; }

        public AdminLoginViewModel()
        {
            _model = new AdminLoginModel();
        }

        public void Authenticate(string Password)
        {
            //MessageBox.Show("Password: " + Password, "Username: " + this.Username);
            bool isAuthenticated = _model.Authenticate(Username, Password);
            if (isAuthenticated)
            {
                Views.AdminOptionsWindow w = new Views.AdminOptionsWindow();
                w.Owner = Application.Current.MainWindow;
                w.Show();
            }
            else
            {
                MessageBox.Show("wrong combination");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models;
using TravelHealthGuide.Views;

namespace TravelHealthGuide.ViewModels
{
    public class AdminOptionsViewModel
    {
        private readonly AdminOptionsModel _model;

        private string _databasePath;
        public string DatabasePathText
        {
            get { return "Database path: " + _databasePath; }
        }

        private string _currentUser;
        public string CurrentUserText
        {
            get { return "You are logged in as " + _currentUser; }
        }

        public AdminOptionsViewModel(string user)
        {
            _model = new AdminOptionsModel();
            _databasePath = _model.GetCurrentWorkingDirectory() + "\\TravelHealthGuide.db";
            _currentUser = user;
        }

        public void OpenDatabaseDirectory()
        {
            _model.OpenCurrentWorkingDirectory();
        }

        public void ChangeUserPassword()
        {
            ChangeUserPasswordWindow w = new ChangeUserPasswordWindow(_currentUser);
            //w.Owner = Window.GetWindow(AdminOptionsWindow);
            w.Show();
        }
    }
}

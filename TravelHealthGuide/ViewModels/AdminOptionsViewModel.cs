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

        private int _countryCount;
        public string CountryCountText
        {
            get { return "There are currently " + _countryCount.ToString() + " countries registered on database"; }
        }

        private int _userCount;
        public string UserCountText
        {
            get { return "There are " + _userCount.ToString() + " authorized users with admin access"; }
        }

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

            _countryCount = _model.CountryCount;
            _userCount = _model.UserCount;
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

        public void ModifyCountryData()
        {
            ModifyDestinationSelectorWindow w = new ModifyDestinationSelectorWindow();
            w.Show();
        }

        public void AddCountryData()
        {
            AddModifyDestinationInfoWindow w = new AddModifyDestinationInfoWindow();
            w.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.Models
{
    public class AdminOptionsModel
    {
        private int _countryCount, _userCount;
        public int CountryCount
        {
            get { return this._countryCount; }
        }
        public int UserCount
        {
            get { return this._userCount; }
        }

        public AdminOptionsModel()
        {
            CountItems();
        }

        public string GetCurrentWorkingDirectory()
            => Directory.GetCurrentDirectory();

        public void OpenCurrentWorkingDirectory()
        {
            Process.Start("explorer.exe", "/select,\""+GetCurrentWorkingDirectory()+"\\TravelHealthGuide.db\"");
        }

        private void CountItems()
        {
            using (var db = new DataBase())
            {
                _countryCount = db.Destinations.Count();
                _userCount = db.Users.Count();
            }
        }
    }
}

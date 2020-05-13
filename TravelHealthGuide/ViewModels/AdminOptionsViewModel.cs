using System;
using System.Collections.Generic;
using System.Text;
using TravelHealthGuide.Models;

namespace TravelHealthGuide.ViewModels
{
    class AdminOptionsViewModel
    {
        private readonly AdminOptionsModel _model;

        public string DatabasePathText { get; set; }

        public AdminOptionsViewModel()
        {
            _model = new AdminOptionsModel();
            DatabasePathText = "Database path: " + _model.GetCurrentWorkingDirectory();
        }

        public void OpenDatabaseDirectory()
        {
            _model.OpenCurrentWorkingDirectory();
        }
    }
}

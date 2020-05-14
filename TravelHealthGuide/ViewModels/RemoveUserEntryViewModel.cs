using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.ViewModels
{
    public class RemoveUserEntryViewModel
    {
        private readonly RemoveUserEntryModel _model;

        public List<UserInfo> DataSource { get; }
        public UserInfo SelectedItem { private get; set; }

        public RemoveUserEntryViewModel()
        {
            _model = new RemoveUserEntryModel();

            using (var db = new DataBase())
            {
                DataSource = db.Users
                    .OrderBy(o => o.UserID)
                    .ToList();
            }
        }

        public bool RemoveSelected()
        {
            MessageBoxResult choice = MessageBox.Show("Remove \"" + SelectedItem.Username + "\" user?", "Confirm User Removal", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            if (choice == MessageBoxResult.OK)
            {
                bool Success = _model.RemoveUser(SelectedItem);
                if (!Success)
                {
                    MessageBox.Show("There is only one user left.", "Could not remove user", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}

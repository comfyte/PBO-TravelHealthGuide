using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models;

namespace TravelHealthGuide.ViewModels
{
    public class ChangeUserPasswordViewModel
    {
        private readonly ChangeUserPasswordModel _model;

        public ChangeUserPasswordViewModel(string username)
        {
            _model = new ChangeUserPasswordModel(username);
        }

        public bool ChangePassword(string OldPassword, string NewPassword, string ConfirmNewPassword)
        {
            int returnCode = _model.ChangePassword(OldPassword, NewPassword, ConfirmNewPassword);
            switch (returnCode)
            {
                case 0:
                    return true;
                case 1:
                    MessageBox.Show("Invalid old password", "Could not change password", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                case 2:
                    MessageBox.Show("Password cannot be blank", "Could not set password", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                case 3:
                    MessageBox.Show("New password doesn't match, please try again", "Could not set password", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                default:
                    return false;
            }
        }
    }
}

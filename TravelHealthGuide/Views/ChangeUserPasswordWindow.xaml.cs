using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TravelHealthGuide.Models;
using TravelHealthGuide.ViewModels;

namespace TravelHealthGuide.Views
{
    /// <summary>
    /// Interaction logic for ChangeUserPasswordWindow.xaml
    /// </summary>
    public partial class ChangeUserPasswordWindow : Window
    {
        private readonly ChangeUserPasswordViewModel _viewmodel;

        public string OldPassword
        {
            get { return OldPasswordField.Password; }
        }
        public string NewPassword
        {
            get { return NewPasswordField.Password; }
        }
        public string ConfirmNewPassword
        {
            get { return ConfirmNewPasswordField.Password; }
        }

        private string _username;

        public ChangeUserPasswordWindow(string username)
        {
            InitializeComponent();
            _viewmodel = new ChangeUserPasswordViewModel(username);
            this.DataContext = _viewmodel;
        }

        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            bool Success = _viewmodel.ChangePassword(OldPassword, NewPassword, ConfirmNewPassword);
            if (Success)
            {
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

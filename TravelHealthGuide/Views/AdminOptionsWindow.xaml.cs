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
using TravelHealthGuide.ViewModels;

namespace TravelHealthGuide.Views
{
    /// <summary>
    /// Interaction logic for AdminOptionsWindow.xaml
    /// </summary>
    public partial class AdminOptionsWindow : Window
    {
        private readonly AdminOptionsViewModel _viewmodel;

        public AdminOptionsWindow(string user)
        {
            InitializeComponent();
            _viewmodel = new AdminOptionsViewModel(user);
            this.DataContext = _viewmodel;
        }

        private void AdminOptionsWindow_OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Log out from admin console?", "Exit confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            if (result == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Owner.Focus();
            }
        }

        private void OpenDBLocationButton_Click(object sender, RoutedEventArgs e)
        {
            _viewmodel.OpenDatabaseDirectory();
        }

        private void DeleteCountryButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveDiseaseEntryWindow w = new RemoveDiseaseEntryWindow();
            w.Owner = this;
            w.Show();
        }

        private void CreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewUserEntryWindow w = new AddNewUserEntryWindow();
            w.Owner = this;
            w.ShowDialog();
        }

        private void RemoveUserButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveUserEntryWindow w = new RemoveUserEntryWindow();
            w.Owner = this;
            w.ShowDialog();
        }

        private void ChangeUserPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            _viewmodel.ChangeUserPassword();
        }
    }
}

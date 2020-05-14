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
    /// Interaction logic for AddNewUserEntryWindow.xaml
    /// </summary>
    public partial class AddNewUserEntryWindow : Window
    {
        private readonly AddNewUserEntryViewModel _viewmodel;

        public AddNewUserEntryWindow()
        {
            InitializeComponent();
            _viewmodel = new AddNewUserEntryViewModel();
            this.DataContext = _viewmodel;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            bool IsCreated = _viewmodel.CreateUser(PasswordField.Password);
            if (IsCreated)
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

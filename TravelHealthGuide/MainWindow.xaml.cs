using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TravelHealthGuide.Models;
using TravelHealthGuide.Models.DatabaseModels;
using TravelHealthGuide.ViewModels;
using TravelHealthGuide.Views;

namespace TravelHealthGuide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewmodel;

        public MainWindow()
        {
            InitializeComponent();
            _viewmodel = new MainViewModel();
            this.DataContext = _viewmodel;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Focus to search box after start
            var SearchField = LocationSearchBox.Template.FindName("PART_EditableTextBox", LocationSearchBox) as TextBox;
            if (SearchField != null)
            {
                SearchField.Focus();
            }

            if (String.IsNullOrEmpty(LocationSearchBox.Text))
            {
                GoButton.Opacity = 0.25;
                GoButton.IsEnabled = false;
                ClearAllButton.Visibility = Visibility.Collapsed;
            }
        }

        private void LocationSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LaunchInfoWindow();
            }
            else if (String.IsNullOrEmpty(((ComboBox)sender).Text) || e.Key == Key.Escape)
            {
                ((ComboBox)sender).IsDropDownOpen = false;
            }
            else if (!((ComboBox)sender).IsDropDownOpen)
            {
                TextBox textBoxBase = (TextBox)((ComboBox)sender).Template.FindName("PART_EditableTextBox", (ComboBox)sender);
                int previousSelectionLength = textBoxBase.SelectionLength;

                ((ComboBox)sender).IsDropDownOpen = true;
                textBoxBase.SelectionStart = textBoxBase.Text.Length - previousSelectionLength;
                textBoxBase.SelectionLength = previousSelectionLength;
            }
        }

        private void LocationSearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(((ComboBox)sender).Text))
            {
                GoButton.Opacity = 0.25;
                GoButton.IsEnabled = false;
                ClearAllButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                GoButton.Opacity = 1;
                GoButton.IsEnabled = true;
                ClearAllButton.Visibility = Visibility.Visible;
            }
        }

        private void ClearAllButton_Click(object sender, RoutedEventArgs e)
        {
            var SearchField = LocationSearchBox.Template.FindName("PART_EditableTextBox", LocationSearchBox) as TextBox;
            SearchField.Clear();
        }

        private void AdminOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            AdminLoginWindow adminAccess = _viewmodel.AdminOptions();
            adminAccess.Owner = this;
            adminAccess.ShowDialog();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            LaunchInfoWindow();
        }

        private void LaunchInfoWindow()
        {
            DiseaseInfoWindow infoWindow = _viewmodel.GetDestinationInfo();
            infoWindow.Owner = this;
            infoWindow.Show();
        }
    }
}

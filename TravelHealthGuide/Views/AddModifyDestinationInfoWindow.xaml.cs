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
using TravelHealthGuide.Models.DatabaseModels;
using TravelHealthGuide.ViewModels;

namespace TravelHealthGuide.Views
{
    /// <summary>
    /// Interaction logic for AddModifyDestinationInfoWindow.xaml
    /// </summary>
    public partial class AddModifyDestinationInfoWindow : Window
    {
        private AddModifyDestinationInfoViewModel _viewmodel;

        public AddModifyDestinationInfoWindow()
        {
            InitializeComponent();
            _viewmodel = new AddModifyDestinationInfoViewModel();
            this.DataContext = _viewmodel;
        }

        public AddModifyDestinationInfoWindow(string SelectedCountry)
        {
            InitializeComponent();
            _viewmodel = new AddModifyDestinationInfoViewModel(SelectedCountry);
            this.DataContext = _viewmodel;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            if (_viewmodel.SaveChanges())
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

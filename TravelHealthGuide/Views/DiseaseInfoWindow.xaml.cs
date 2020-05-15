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
    /// Interaction logic for DiseaseInfoWindow.xaml
    /// </summary>
    public partial class DiseaseInfoWindow : Window
    {
        private DiseaseInfoViewModel _viewmodel;

        public DiseaseInfoWindow(string countryName)
        {
            InitializeComponent();
            _viewmodel = new DiseaseInfoViewModel(countryName);
            this.DataContext = _viewmodel;
        }

        private void DiseaseInfoWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (!_viewmodel.Success)
            {
                MessageBox.Show("\"" + _viewmodel.CountryName + "\" does not exist in database.", "Could not find country data", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
                Application.Current.MainWindow.Focus();
            }
        }
    }
}

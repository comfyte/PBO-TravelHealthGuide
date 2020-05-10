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

namespace TravelHealthGuide.Views
{
    /// <summary>
    /// Interaction logic for DiseaseInfoWindow.xaml
    /// </summary>
    public partial class DiseaseInfoWindow : Window
    {
        public string countryName { get; }

        public DiseaseInfoWindow(string CountryName)
        {
            InitializeComponent();

            // Testing, to be changed later
            this.countryName = CountryName;
            CountryTitle.DataContext = this;

            
        }
    }
}

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

        public List<string> LSoT;

        public DiseaseInfoWindow(string countryName)
        {
            InitializeComponent();
            _viewmodel = new DiseaseInfoViewModel(countryName);
            this.DataContext = _viewmodel;
            ///testing
            //LSoT = new List<string>
            //{
            //    "Malaria\nY"
            //}
        }
    }
}

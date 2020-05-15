using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models;
using TravelHealthGuide.Models.DatabaseModels;
using TravelHealthGuide.Views;

namespace TravelHealthGuide.ViewModels
{
    public class MainViewModel
    {
        private readonly MainModel _model;

        public List<string> CountryList { get; set; }

        public string LocationSearchQuery { set; private get; }

        public MainViewModel()
        {
            _model = new MainModel();
            this.CountryList = PopulateCountryList();
        }

        private List<string> PopulateCountryList()
        {
            return _model.ListCountries();
        }

        public DiseaseInfoWindow GetDestinationInfo()
        {
            return new DiseaseInfoWindow(LocationSearchQuery);
        }

        public AdminLoginWindow AdminOptions()
        {
            return new AdminLoginWindow();
        }
    }
}

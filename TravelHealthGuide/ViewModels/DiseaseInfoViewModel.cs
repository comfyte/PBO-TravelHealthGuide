using System;
using System.Collections.Generic;
using System.Text;

namespace TravelHealthGuide.ViewModels
{
    class DiseaseInfoViewModel
    {
        public string CountryName { get; }
        public DiseaseInfoViewModel(string countryName)
        {
            this.CountryName = countryName;
        }
    }
}

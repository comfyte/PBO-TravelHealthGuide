using System;
using System.Collections.Generic;
using System.Text;

namespace TravelHealthGuide.ViewModels
{
    class DiseaseInfoViewModel
    {
        public string CountryName { get; }

        public List<string> LSoT { get; set; }

        public DiseaseInfoViewModel(string countryName)
        {
            this.CountryName = countryName;

            // testing value
            LSoT = new List<string>
            {
                "Malaria\nY",
                "Yellow Fever",
                "Malaria\nY",
                "Yellow Fever",
                "Malaria\nY",
                "Yellow Fever",
                "Malaria\nY",
                "Yellow Fever",
                "Malaria\nY",
                "Yellow Fever",
                "Malaria\nY",
                "Yellow Fever",
                "Malaria\nY",
                "Yellow Fever",
                "Malaria\nY",
                "Yellow Fever",
                "Malaria\nY",
                "Yellow Fever",
                "Malaria\nY",
                "Yellow Fever"
            };
        }
    }
}

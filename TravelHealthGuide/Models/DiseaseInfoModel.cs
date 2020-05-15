using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.Models
{
    public class DiseaseInfoModel
    {
        private DestinationInfo _result;

        public DiseaseInfoModel(string countryName)
        {
            using (var db = new DataBase())
            {
                try
                {
                    _result = db.Destinations
                        .Where(c => c.CountryName == countryName)
                        .First();
                }
                catch
                { 
                    // Null value is already handled
                }
            }
        }

        public bool Found()
        {
            if (_result != null)
            {
                return true;
            }
            return false;
        }

        public string GetDiseaseRisks()
        {
            if (_result != null)
                return _result.DiseaseRisks;

            return "Error";
        }

        public string GetVaccinationRequirements()
        {
            if (_result != null)
                return _result.VaccintionRequirements;

            return "Error";
        }

        public string GetRecommendedActions()
        {
            if (_result != null)
                return _result.RecommendedActions;

            return "Error";
        }
    }
}

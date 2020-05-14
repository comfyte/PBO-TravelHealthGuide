using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.ViewModels
{
    public class AddModifyDestinationInfoViewModel
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        protected string _diseaseRisks = "";
        public string DiseaseRisks
        {
            get 
            { 
                return _diseaseRisks
                    .Replace(": ", Environment.NewLine)
                    .Replace("&& ", Environment.NewLine+Environment.NewLine); 
            }
            set 
            {
                _diseaseRisks = value
                  .Replace(Environment.NewLine + Environment.NewLine, "&& ")
                  .Replace(Environment.NewLine, ": ");
            }
        }

        protected string _vaccinationRequirements = "";
        public string VaccinationRequirements
        {
            get
            {
                return _vaccinationRequirements
                    .Replace(": ", Environment.NewLine)
                    .Replace("&& ", Environment.NewLine + Environment.NewLine);
            }
            set
            {
                _vaccinationRequirements = value
                  .Replace(Environment.NewLine + Environment.NewLine, "&& ")
                  .Replace(Environment.NewLine, ": ");
            }
        }

        protected string _recommendedActions = "";
        public string RecommendedActions
        {
            get
            {
                return _recommendedActions
                    .Replace(": ", Environment.NewLine)
                    .Replace("&& ", Environment.NewLine + Environment.NewLine);
            }
            set
            {
                _recommendedActions = value
                  .Replace(Environment.NewLine + Environment.NewLine, "&& ")
                  .Replace(Environment.NewLine, ": ");
            }
        }

        private DestinationInfo destinationInfo;
        private string _selectedCountry;


        public AddModifyDestinationInfoViewModel()
        {

        }

        public AddModifyDestinationInfoViewModel(string selectedCountry)
        {
            destinationInfo = new DestinationInfo();
            _selectedCountry = selectedCountry;

            using (var db = new DataBase())
            {
                destinationInfo = db.Destinations
                    .Where(x => x.CountryName == selectedCountry)
                    .First();
            }

            this.CountryName = destinationInfo.CountryName;
            this.CountryCode = destinationInfo.CountryCode;
            this._diseaseRisks = destinationInfo.DiseaseRisks;
            this._vaccinationRequirements = destinationInfo.VaccintionRequirements;
            this._recommendedActions = destinationInfo.RecommendedActions;

        }

        public bool SaveChanges()
        {
            using (var db = new DataBase())
            {
                if (_selectedCountry != null)
                {
                    destinationInfo = db.Destinations
                        .Where(x => x.CountryName == _selectedCountry)
                        .First();
                }
                else
                {
                    destinationInfo = new DestinationInfo();

                    // Check for existing country
                    int checkExisting = db.Destinations
                        .Where(x => (x.CountryName == this.CountryName) || (x.CountryCode == this.CountryCode))
                        .Count();
                    if (checkExisting > 0)
                    {
                        MessageBox.Show("Country already exists on database", "Could not add country data", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                }
                destinationInfo.CountryName = this.CountryName;
                destinationInfo.CountryCode = this.CountryCode;
                destinationInfo.DiseaseRisks = this._diseaseRisks;
                destinationInfo.VaccintionRequirements = this._vaccinationRequirements;
                destinationInfo.RecommendedActions = this._recommendedActions;

                if (_selectedCountry == null)
                {
                    db.Add(destinationInfo);
                }

                db.SaveChanges();
            }
            return true;
        }

    }
}

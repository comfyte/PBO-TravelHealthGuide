using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelHealthGuide.Models;

namespace TravelHealthGuide.ViewModels
{
    class DiseaseInfoViewModel
    {
        private readonly DiseaseInfoModel _model;

        public string CountryName { get; }

        public bool Success
        {
            get { return _model.Found(); }
        }

        private string _diseaseRisks;
        public List<string> DiseaseRisks
        {
            get { return Listify(_diseaseRisks); }
        }

        private string _vaccinationRequirements;
        public List<string> VaccinationRequirements
        {
            get { return Listify(_vaccinationRequirements); }
        }

        private string _recommendedActions;
        public List<string> RecommendedActions
        {
            get { return Listify(_recommendedActions); }
        }

        public DiseaseInfoViewModel(string countryName)
        {
            _model = new DiseaseInfoModel(countryName);
            this.CountryName = countryName;

            _diseaseRisks = _model.GetDiseaseRisks();
            _vaccinationRequirements = _model.GetVaccinationRequirements();
            _recommendedActions = _model.GetRecommendedActions();
        }

        private List<string> Listify(string plainString)
        {
            return plainString.Replace(": ", Environment.NewLine).Split("&& ").ToList();
        }
    }
}

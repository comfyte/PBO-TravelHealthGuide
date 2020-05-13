using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace TravelHealthGuide.Models.DatabaseModels
{
    public class DestinationInfo
    {
        public int Id { get; set; }

        [Required]
        public string CountryName { get; set; }
        [Required]
        public string CountryCode { get; set; }

        public string DiseaseRisks { get; set; }
        public string VaccintionRequirements { get; set; }
        public string RecommendedActions { get; set; }
    }
}

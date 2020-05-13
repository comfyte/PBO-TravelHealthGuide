using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelHealthGuide.Models.DatabaseModels
{
    public class DiseaseData
    {
        [Key]
        public int DiseaseID { get; set; }

        public enum MalariaPreventionType { A, B, C }
        public string Name { get; set; }
        public uint Year { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string CountryRequirementAtEntry { get; set; }
        public bool VaccinationRecommendation { get; set; }
        public MalariaPreventionType MalariaPrevention { get; set; }
    }
}

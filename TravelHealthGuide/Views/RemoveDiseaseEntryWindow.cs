using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using TravelHealthGuide.ViewModels;

namespace TravelHealthGuide.Views
{
    public class RemoveDiseaseEntryWindow : RemoveDatabaseEntryWindowBase
    {
        private readonly RemoveDiseaseEntryViewModel _viewmodel;

        public RemoveDiseaseEntryWindow() : base()
        {
            _viewmodel = new RemoveDiseaseEntryViewModel();
            this.DataContext = _viewmodel;

            base.AddColumns(new List<GridViewColumn>
            {
                base.GenerateColumns("ID", 25, "Id"),
                base.GenerateColumns("Country Name", 150, "CountryName"),
                base.GenerateColumns("Code", 40, "CountryCode"),
                base.GenerateColumns("Disease Risks", 180, "DiseaseRisks"),
                base.GenerateColumns("Vaccination Requirements", 180, "VaccinationRequirements"),
                base.GenerateColumns("Recommended Actions", 180, "RecommendedActions")
            });
        }

        protected override void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            bool Complete = _viewmodel.RemoveSelected();
            if (Complete)
            {
                this.Close();
            }
        }
    }
}

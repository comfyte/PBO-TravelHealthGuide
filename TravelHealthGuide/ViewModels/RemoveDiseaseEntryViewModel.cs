using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TravelHealthGuide.Models;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.ViewModels
{
    public class RemoveDiseaseEntryViewModel
    {
        private readonly RemoveDiseaseEntryModel _model;

        public List<DestinationInfo> DataSource { get; }
        public DestinationInfo SelectedItem { private get; set; }

        public RemoveDiseaseEntryViewModel()
        {
            _model = new RemoveDiseaseEntryModel();

            using (var db = new DataBase())
            {
                DataSource = db.Destinations
                    .OrderBy(o => o.Id)
                    .ToList();
            }
        }

        public bool RemoveSelected()
        {
            MessageBoxResult choice = MessageBox.Show("Remove \"" + SelectedItem.CountryName + "\" entry from database?", "Confirm Entry Removal", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            if (choice == MessageBoxResult.OK)
            {
                _model.RemoveItem(SelectedItem);
                return true;
            }
            return false;
        }
    }
}

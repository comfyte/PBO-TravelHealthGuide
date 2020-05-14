using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TravelHealthGuide.Models.DatabaseModels;
using TravelHealthGuide.Views;

namespace TravelHealthGuide.ViewModels
{
    public class ModifyDestinationSelectorViewModel
    {
        public List<string> CountryDataSource { get; private set; }
        public string Selected { get; set; }

        public ModifyDestinationSelectorViewModel()
        {
            using (var db = new DataBase())
            {
                CountryDataSource = db.Destinations
                    .OrderBy(n => n.CountryName)
                    .Select(c => c.CountryName)
                    .ToList();
            }
        }

        public void Proceed()
        {
            AddModifyDestinationInfoWindow w = new AddModifyDestinationInfoWindow(Selected);
            w.Show();
        }
    }
}

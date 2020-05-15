using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.Models
{
    public class MainModel
    {
        public List<string> ListCountries()
        {
            List<string> Countries;
            using (var db = new DataBase())
            {
                Countries = db.Destinations
                    .OrderBy(n => n.CountryName)
                    .Select(c => c.CountryName)
                    .ToList();
            }
            return Countries;
        }
    }
}

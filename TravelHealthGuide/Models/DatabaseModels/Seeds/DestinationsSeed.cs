using System;
using System.Collections.Generic;
using System.Text;

namespace TravelHealthGuide.Models.DatabaseModels.Seeds
{
    public class DestinationsSeed
    {
        public List<DestinationInfo> Items { get; }

        public DestinationsSeed()
        {
            this.Items = new List<DestinationInfo>
            {
                new DestinationInfo
                {
                    Id = 1, // Wajib diisi
                    CountryName = "Afghanistan", // Wajib diisi
                    CountryCode = "AF", // Wajib diisi
                    DiseaseRisks = "Malaria (2019): Malaria risk due to P. falciparum and P. vivax exists from May through November below 2000 m.",
                    // Karena Afghanistan di bagian penyakit Yellow Fever isinya "No" semua, jadi nggak usah dimasukin
                    VaccintionRequirements = "Polio (2019): Proof of polio vaccination is required for travellers coming from a polio-endemic country. For residents or travellers who stay in Afghanistan for more than 4 weeks, a proof of polio vaccination may be required when departing from Afghanistan. This vaccination should be received between 4 weeks and 12 months before the date of departure.",
                    RecommendedActions = "Malaria: Mosquito-bite prevention plus atovaquoneproguanil or doxycycline or mefloquine chemoprophylaxis  (select according to drugresistance pattern, reported side-effects and contraindications)."
                },
                new DestinationInfo
                {
                    Id = 2,
                    CountryName = "Albania",
                    CountryCode = "AL",
                    VaccintionRequirements = "Yellow Fever (prior to 2013): A yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission."
                },
                new DestinationInfo
                {
                    Id = 3,
                    CountryName = "Indonesia",
                    CountryCode = "ID",
                    DiseaseRisks = "Malaria (2018): Malaria risk exists throughout the year in most areas of the five eastern provinces of East Nusa Tenggara, Maluku, North Maluku, Papua and West Papua. In other parts of the country, there is malaria risk in some districts, except in Jakarta municipality, in cities and urban areas, and in the areas of the main tourist resorts. P. vivax resistance to chloroquine has been reported. Human P. knowlesi infection has been reported in the province of Kalimantan.",
                    VaccintionRequirements = "Yellow Fever (2019): A yellow fever vaccination certificate is required for travellers aged 9 months or over arriving from countries with risk of yellow fever transmission."
                    + "&& Meningitis (2019): Proof of meningococcal (groups A, C, Y and W-135) meningitis vaccination is required for travellers departing to and arriving from Saudi Arabia",
                    RecommendedActions = "Malaria: Mosquito-bite prevention plus atovaquoneproguanil or doxycycline or mefloquine chemoprophylaxis (select according to drugresistance pattern, reported side-effects and contraindications)."
                },
                // Tolong dilanjutin
                
            };
        }
    }
}

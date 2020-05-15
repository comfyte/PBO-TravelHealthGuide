using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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
                new DestinationInfo
                {
                    Id = 4,
                    CountryName = "Australia",
                    CountryCode = "AU",
                    VaccintionRequirements = "Yellow Fever (2019): a yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission (with the exception of Galápagos Islands in Ecuador) and for travellers having transited for more than 12 hours through an airport of a country with risk of yellow fever transmission(with the same exception as mentioned above)."
                },
                new DestinationInfo
                {
                    Id = 5,
                    CountryName = "Argentina",
                    CountryCode = "AG",
                    VaccintionRequirements = "Yellow Fever : Recommended for all travellers aged 9 months or over going to Corrientes and Misiones provinces. " +
                    "&& Generally not recommended for travellers going to Formosa Province and designated areas of Chaco, Jujuy and Salta provinces. " +
                    "&& Not recommended for travellers whose itineraries are limited to areas and provinces not listed above."
                },
                new DestinationInfo
                {
                    Id = 6,
                    CountryName = "Austria",
                    CountryCode = "AT",
                },
                new DestinationInfo
                {
                    Id = 7,
                    CountryName = "Bangladesh",
                    CountryCode = "BD",
                    DiseaseRisks = "Malaria (2019): Malaria risk exists throughout the year with a peak from May through October, but transmission occurs only in 13 of 64 districts in both rural and urban areas. Risk is high in Chittagong Hill Tract districts (Bandarban, Rangamati and Khagrachari), Chattogram District, and Cox's Bazaar District. Low risk exists in the districts of Hobigonj, Kurigram, Moulvibazar, Mymensingh, Netrakona, Sherpur, Sunamgonj and Sylhet. Most parts of the country, including Dhaka City, have no risk of malaria.",
                    VaccintionRequirements = "Yellow Fever (2019): a yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission and for travellers having transited through an airport of a country with risk of yellow fever transmission.",
                    RecommendedActions = "Malaria : Mosquito-bite prevention plus atovaquoneproguanil or doxycycline or mefloquine chemoprophylaxis (select according to drugresistance pattern, reported side-effects and contraindications)"
                },
                new DestinationInfo
                {
                    Id = 8,
                    CountryName = "Belgium",
                    CountryCode = "BE",
                },
                new DestinationInfo
                {
                    Id = 9,
                    CountryName = "Bolivia",
                    CountryCode = "BO",
                    DiseaseRisks = "Malaria (2018): Malaria risk due almost exclusively to P. vivax (99.9%) exists throughout the year in the entire country below 2500 m. The risk of malaria is highest in the northern departments of Beni and Pando, especially in the localities of Riberalta, Guayaramerín and Sena.",
                    VaccintionRequirements = "Yellow Fever : a yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission." +
                    "&& Recommended for all travellers aged 9 months or over going to the following areas east of the Andes below 2300 m: the entire departments of Beni, Pando and Santa Cruz; and designated areas of the departments of Chuquisaca, Cochabamba, La Paz and Tarija." +
                    "&& Not recommended for travellers whose itineraries are limited to areas above 2300 m and all areas not listed above, including the cities of La Paz and Sucre.",
                    RecommendedActions = "Malaria : Mosquito-bite prevention plus chloroquine, or doxycycline or atovaquone-proguanil or mefloquine chemoprophylaxis (select according to drug-resistance pattern, reported side-effects and contraindications)"
                },
                new DestinationInfo
                {
                    Id = 10,
                    CountryName = "Brazil",
                    CountryCode = "BR",
                    DiseaseRisks = "Malaria (2019): Malaria risk due to P. vivax (88.8%), P. falciparum (10.6%) and mixed infections (0.5%) exists in most forested areas below 900 m within the nine states of the Amazon region (Acre, Amapá, Amazonas, Maranhão, Mato Grosso [northern part], Pará [except Belém City], Rondônia, Roraima and Tocantins [western part]).Transmission intensity varies from one municipality to another and is higher in jungle-mining areas, in agricultural settlements, in indigenous areas, and in some peripheral urban areas of Cruzeiro do Sul, Manaus and Pôrto Velho. Malaria also occurs on the periphery of large cities such as Boa Vista, Macapá, Maraba, Rio Branco and Santarém. In the states outside the administrative region of Amazonas, the risk of malaria transmission is negligible or non - existent, but there is a residual risk of P.vivax transmission in Atlantic forest areas of the states of São Paulo, Minas Gerais, Rio de Janeiro and Espirito Santo.Detailed information on the epidemiological situation of malaria in Brazil is available at www.saude.gov.br / malaria.",
                    VaccintionRequirements = "Recommended for all travellers aged 9 months or over going to the states of Acre, Amapá, Amazonas, Distrito Federal (including the capital city of Brasília), Espirito Santo, Goiás, Maranhão, Mato Grosso, Mato Grosso do Sul, Minas Gerais, Pará, Paraná, Piauí, Rio de Janeiro, Rio Grande do Sul, Rondônia, Roraima, Santa Catarina, Sao Paulo, Tocantins; as well as to designated areas of Bahia State.Vaccination is also recommended for travellers visiting Iguazu Falls." +
                    "&& Not recommended for travellers whose itineraries are limited to areas not listed above, including the cities of Fortaleza and Recife.",
                    RecommendedActions = "Malaria (in P. vivax risk areas): Risk of non-falciparum malaria Mosquito-bite prevention plus chloroquine, or doxycycline or atovaquone-proguanil or mefloquine chemoprophylaxis (select according to drug-resistance pattern, reported side-effects and contraindications)" +
                    "&& Malaria (in P. falciparum risk areas): Risk of P. falciparum malaria Mosquito-bite prevention plus atovaquone proguanil or doxycycline or mefloquine chemoprophylaxis (select according to drug resistance pattern, reported side-effects and contraindications)"
                },
                new DestinationInfo
                {
                    Id = 11,
                    CountryName = "China",
                    CountryCode = "CN",
                    DiseaseRisks = "Malaria (2019): China has achieved tremendous success in malaria elimination. Since 2017, no indigenous cases have been reported.",
                    VaccintionRequirements = "Yellow Fever (2019): a yellow fever vaccination certificate is required for travellers aged 9 months or over arriving from countries with risk of yellow fever transmission and for travellers having transited through an airport of a country with risk of yellow fever transmission.This requirement does not apply to travellers whose itineraries are limited to Hong Kong Special Administrative Region(SAR) and Macao SAR.",
                    RecommendedActions = "Malaria : Very limited risk of malaria transmission Mosquito-bite prevention only"
                },
                new DestinationInfo
                {
                    Id = 12,
                    CountryName = "Congo",
                    CountryCode = "CG",
                    DiseaseRisks = "Malaria (2018): Malaria risk due predominantly to P. falciparum exists throughout the year in the entire country.",
                    VaccintionRequirements = "Yellow Fever (2019): a yellow fever vaccination certificate is required for all travellers aged 9 months or over.",
                    RecommendedActions = "Malaria : Risk of P. falciparum malaria Mosquito-bite prevention plus atovaquone proguanil or doxycycline or mefloquine chemoprophylaxis (select according to drug resistance pattern, reported side-effects and contraindications)"
                },
                new DestinationInfo
                {
                    Id = 13,
                    CountryName = "Dominica",
                    CountryCode = "DM",
                    VaccintionRequirements = "a yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission and for travellers having transited for more than 12 hours through an airport of a country with risk of yellow fever transmission."
                },
                new DestinationInfo
                {
                    Id = 14,
                    CountryName = "Egypt",
                    CountryCode = "EG",
                    DiseaseRisks = "Malaria (2019): Very limited malaria risk due to P. falciparum and P. vivax may exist from June through October in El Faiyûm Governorate. No indigenous cases have been reported since 1998.",
                    VaccintionRequirements = "Yellow Fever (2019): a yellow fever vaccination certificate is required for travellers aged 9 months or over arriving from countries with risk of yellow fever transmission (with the addition of Eritrea, Rwanda, Somalia, United Republic of Tanzania and Zambia) and for travellers having transited for more than 12 hours through an airport of a country with risk of yellow fever transmission(with the same additions mentioned above).In the absence of a vaccination certificate, the individual will be detained in quarantine for up to 6 days of departure from an area at risk of yellow fever transmission."
                    + "&& Polio: Polio vaccination is requested regardless of age and vaccination status. Proof of receipt of a dose of oral polio vaccine (OPV) or inactivated poliovirus vaccine (IPV) in the form of an international vaccination certificate as specified in Annex 6 of the IHR issued within the previous 12 months and at least 4 weeks before departure is required for travellers arriving from Afghanistan, Nigeria, Pakistan, Papua New Guinea and Somalia) to apply for an entry visa.Proof of vaccination with OPV or IPV is required from all travellers arriving from Democratic Republic of the Congo, Kenya, Niger and Syrian Arab Republic."
                },
                new DestinationInfo
                {
                    Id = 15,
                    CountryName = "Ethiopia",
                    CountryCode = "ET",
                    DiseaseRisks = "Malaria (2018): Malaria risk due to approximately 60% P. falciparum and 40% P. vivax exists throughout the year in the entire country below 2000 m. P. vivax resistance to chloroquine reported. There is no malaria risk in Addis Ababa.",
                    VaccintionRequirements = "Yellow Fever (2018): a yellow fever vaccination certificate is required for travellers aged 9 months or over arriving from countries with risk of yellow fever transmission and for travellers having transited for more than 12 hours through an airport of a country with risk of yellow fever transmission."
                    + "&& Recommended for all travellers aged 9 months or over, except as mentioned below." + "&& Generally not recommended for travellers whose itineraries are limited to Afar and Somali provinces.",
                    RecommendedActions = "Malaria : Risk of P. falciparum malaria Mosquito-bite prevention plus atovaquone proguanil or doxycycline or mefloquine chemoprophylaxis (select according to drug resistance pattern, reported side-effects and contraindications)"
                },
                new DestinationInfo
                {
                    Id = 16,
                    CountryName = "France",
                    CountryCode = "FR",
                },
                new DestinationInfo
                {
                    Id = 17,
                    CountryName = "Greece",
                    CountryCode = "GR",
                    DiseaseRisks = "Malaria (2017): Very limited malaria risk (P. vivax only) may exist from May through October in certain high-risk agricultural areas.",
                    RecommendedActions = "Malaria: Very limited risk of malaria transmission Mosquito-bite prevention only"
                },
                new DestinationInfo
                {
                    Id = 18,
                    CountryName = "Iran",
                    CountryCode = "IR",
                    DiseaseRisks = "Malaria (2018): Malaria risk due to P. vivax and very limited risk due to P. falciparum exist from March through November in rural areas of the provinces of Hormozgan and Kerman (tropical part) and the southern part of Sistan and Baluchestan.",
                    VaccintionRequirements = "Yellow Fever (2018): a yellow fever vaccination certificate is required for travellers aged 9 months or over arriving from countries with risk of yellow fever transmission and for travellers having transited for more than 12 hours through an airport of a country with risk of yellow fever transmission."
                    + "&& Polio: Proof of polio vaccination between 4 weeks and 12 months prior to arrival to Iran is required for all travellers of all ages arriving from a polio-endemic country (Afghanistan, Nigeria, Pakistan). If such a certificate cannot be presented, travellers will receive a dose of polio vaccine at entry.",
                    RecommendedActions = "Malaria : Risk of P. falciparum malaria Mosquito-bite prevention plus atovaquone proguanil or doxycycline or mefloquine chemoprophylaxis (select according to drug resistance pattern, reported side-effects and contraindications)"
                },
                new DestinationInfo
                {
                    Id = 19,
                    CountryName = "Jamaica",
                    CountryCode = "JM",
                    VaccintionRequirements = "Yellow Fever (2017): a yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission and for travellers having transited for more than 12 hours through an airport of a country with risk of yellow fever transmission."
                },
                new DestinationInfo
                {
                    Id = 20,
                    CountryName = "Japan",
                    CountryCode = "JP"
                },
                new DestinationInfo
                {
                    Id = 21,
                    CountryName = "Kenya",
                    CountryCode = "KE",
                    VaccintionRequirements = "a yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission. ",
                    DiseaseRisks = "Malaria (prior to 2018)  Malaria risk due predominantly to P. falciparum exists throughout the year in the entire country. Normally, there is little risk in the city of Nairobi and in the highlands (above 2500 m) of Central, Eastern, Nyanza, Rift Valley and Western provinces. ",
                    RecommendedActions = "Malaria: Mosquito-bite prevention plus atovaquoneproguanil or doxycycline or mefloquine chemoprophylaxis (select according to drugresistance pattern, reported side-effects and contraindications) "
                },
                new DestinationInfo
                {
                    Id = 22,
                    CountryName = "Cambodia",
                    CountryCode = "KH"
                },
                new DestinationInfo
                {
                    Id = 23,
                    CountryName = "North Korea",
                    CountryCode = "KP"
                },
                new DestinationInfo
                {
                    Id = 24,
                    CountryName = "South Korea",
                    CountryCode = "KR"
                },
                new DestinationInfo
                {
                    Id = 25,
                    CountryName = "Kuwait",
                    CountryCode = "KW"
                },
                new DestinationInfo
                {
                    Id = 26,
                    CountryName = "Kazakhstan",
                    CountryCode = "KZ"
                },
                new DestinationInfo
                {
                    Id = 27,
                    CountryName = "Lebabon",
                    CountryCode = "LB",
                    VaccintionRequirements = "Polio vaccination is required for travellers arriving from or going to affected countries, in accordance with WHO recommendations. Proof of meningococcal (groups A, C, Y and W-135) meningitis vaccination is required for travellers going to Hajj, Umrah and to some African countries. "
                },
                new DestinationInfo
                {
                    Id = 28,
                    CountryName = "Sri Lanka",
                    CountryCode = "LK"
                },
                new DestinationInfo
                {
                    Id = 29,
                    CountryName = "Lithuania",
                    CountryCode = "LT"

                },
                new DestinationInfo
                {
                    Id = 30,
                    CountryName = "Luxembourg",
                    CountryCode = "LU"
                },
                new DestinationInfo
                {
                    Id = 31,
                    CountryName = "Libya",
                    CountryCode = "LY",
                    VaccintionRequirements = " a yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission.  "
                },
                new DestinationInfo
                {
                    Id = 32,
                    CountryName = "Morocco",
                    CountryCode = "MA"
                },
                new DestinationInfo
                {
                    Id = 33,
                    CountryName = "Monaco",
                    CountryCode = "MC"
                },
                new DestinationInfo
                {
                    Id = 34,
                    CountryName = "Montenegro",
                    CountryCode = "ME"
                },
                new DestinationInfo
                {
                    Id = 35,
                    CountryName = "Madagascar",
                    CountryCode = "MG",
                    DiseaseRisks = "Malaria (2018):  Malaria risk due predominantly to P. falciparum exists throughout the year in the entire country, with the highest risk in coastal areas.",
                    VaccintionRequirements = "a yellow fever vaccination certificate is required for travellers aged 9 months or over arriving from countries with risk of yellow fever transmission and for travellers having transited for more than 12 hours through an airport of a country with risk of yellow fever transmission.",
                    RecommendedActions = "Mosquito-bite prevention plus atovaquoneproguanil or doxycycline or mefloquine chemoprophylaxis (select according to drugresistance pattern, reported side-effects and contraindications)"
                },
                new DestinationInfo
                {
                    Id = 36,
                    CountryName = "Mali",
                    CountryCode = "ML",
                    DiseaseRisks = "Malaria (2018):  Malaria risk due predominantly to P. falciparum exists throughout the year in the entire country.  ",
                    VaccintionRequirements = " a yellow fever vaccination certificate is required for all travellers aged 1 year or over. ",
                    RecommendedActions = "Mosquito-bite prevention plus atovaquoneproguanil or doxycycline or mefloquine chemoprophylaxis (select according to drugresistance pattern, reported side-effects and contraindications)",
                },
                new DestinationInfo
                {
                    Id = 37,
                    CountryName = "Myanmar",
                    CountryCode = "MM"
                },
                new DestinationInfo
                {
                    Id = 38,
                    CountryName = "Mongolia",
                    CountryCode = "MN"
                },
                new DestinationInfo
                {
                    Id = 39,
                    CountryName = "Macao",
                    CountryCode = "MO"
                },
                new DestinationInfo
                {
                    Id = 40,
                    CountryName = "Maldives",
                    CountryCode = "MV",
                    VaccintionRequirements = "a yellow fever vaccination certificate is required for travellers aged 9 months or over arriving from countries with risk of yellow fever transmission and for travellers having transited for more than 12 hours through an airport of a country with risk of yellow fever transmission. "
                },
                new DestinationInfo
                {
                    Id = 41,
                    CountryName = "Malaysia",
                    CountryCode = "MY",
                    DiseaseRisks = "Malaria (2019):  Malaria risk exists only in limited foci in the deep hinterland of the states of Sabah and Sarawak and the central areas of Peninsular Malaysia. Urban, suburban and coastal areas are free from malaria. Human P. knowlesi infection has been reported.  ",
                    VaccintionRequirements = " a yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission and for travellers having transited for more than 12 hours through an airport of a country with risk of yellow fever transmission.  ",
                    RecommendedActions = "Mosquito-bite prevention plus atovaquoneproguanil or doxycycline or mefloquine chemoprophylaxis (select according to drugresistance pattern, reported side-effects and contraindications)"
                }

            };
        }
    }
}

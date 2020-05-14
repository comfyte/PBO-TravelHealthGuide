using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TravelHealthGuide.Models;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Stub to populate combobox contents
            List<string> comboboxContents = new List<string>();

            string countries = "Afghanistan, Albania, Algeria, American Samoa, Andorra, Angola, Anguilla, Antarctica, Antigua and Barbuda, Argentina, Armenia, Aruba, Australia, Austria, Azerbaijan, Bahamas, Bahrain, Bangladesh, Barbados, Belarus, Belgium, Belize, Benin, Bermuda, Bhutan, Bolivia, Bosnia and Herzegovina, Botswana, Bouvet Island, Brazil, British Indian Ocean Territory, Brunei Darussalam, Bulgaria, Burkina Faso, Burundi, Cambodia, Cameroon, Canada, Cape Verde, Cayman Islands, Central African Republic, Chad, Chile, China, Christmas Island, Cocos (Keeling Islands), Colombia, Comoros, Congo, Cook Islands, Costa Rica, Cote D'Ivoire (Ivory Coast), Croatia (Hrvatska, Cuba, Cyprus, Czech Republic, Denmark, Djibouti, Dominica, Dominican Republic, East Timor, Ecuador, Egypt, El Salvador, Equatorial Guinea, Eritrea, Estonia, Ethiopia, Falkland Islands (Malvinas), Faroe Islands, Fiji, Finland, France, France, Metropolitan, French Guiana, French Polynesia, French Southern Territories, Gabon, Gambia, Georgia, Germany, Ghana, Gibraltar, Greece, Greenland, Grenada, Guadeloupe, Guam, Guatemala, Guinea, Guinea-Bissau, Guyana, Haiti, Heard and McDonald Islands, Honduras, Hong Kong, Hungary, Iceland, India, Indonesia, Iran, Iraq, Ireland, Israel, Italy, Jamaica, Japan, Jordan, Kazakhstan, Kenya, Kiribati, Korea (North), Korea (South), Kuwait, Kyrgyzstan, Laos, Latvia, Lebanon, Lesotho, Liberia, Libya, Liechtenstein, Lithuania, Luxembourg, Macau, Macedonia, Madagascar, Malawi, Malaysia, Maldives, Mali, Malta, Marshall Islands, Martinique, Mauritania, Mauritius, Mayotte, Mexico, Micronesia, Moldova, Monaco, Mongolia, Montserrat, Morocco, Mozambique, Myanmar, Namibia, Nauru, Nepal, Netherlands, Netherlands Antilles, New Caledonia, New Zealand, Nicaragua, Niger, Nigeria, Niue, Norfolk Island, Northern Mariana Islands, Norway, Oman, Pakistan, Palau, Panama, Papua New Guinea, Paraguay, Peru, Philippines, Pitcairn, Poland, Portugal, Puerto Rico, Qatar, Reunion, Romania, Russian Federation, Rwanda, Saint Kitts and Nevis, Saint Lucia, Saint Vincent and The Grenadines, Samoa, San Marino, Sao Tome and Principe, Saudi Arabia, Senegal, Seychelles, Sierra Leone, Singapore, Slovak Republic, Slovenia, Solomon Islands, Somalia, South Africa, S. Georgia and S. Sandwich Isls., Spain, Sri Lanka, St. Helena, St. Pierre and Miquelon, Sudan, Suriname, Svalbard and Jan Mayen Islands, Swaziland, Sweden, Switzerland, Syria, Taiwan, Tajikistan, Tanzania, Thailand, Togo, Tokelau, Tonga, Trinidad and Tobago, Tunisia, Turkey, Turkmenistan, Turks and Caicos Islands, Tuvalu, Uganda, Ukraine, United Arab Emirates, United Kingdom (Britain / UK), United States of America (USA), US Minor Outlying Islands, Uruguay, Uzbekistan, Vanuatu, Vatican City State (Holy See), Venezuela, Viet Nam, Virgin Islands (British), Virgin Islands (US), Wallis and Futuna Islands, Western Sahara, Yemen, Yugoslavia, Zaire, Zambia, Zimbabwe";
            comboboxContents = countries.Split(", ").ToList();

            //LocationSearchBox.ItemsSource = comboboxContents;

            List<string> Countries;
            // Test DB
            using (var db = new DataBase())
            {
                Countries = db.Destinations
                    .OrderBy(n => n.CountryName)
                    .Select(c => c.CountryName)
                    .ToList();
            }
            LocationSearchBox.ItemsSource = Countries;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var SearchField = LocationSearchBox.Template.FindName("PART_EditableTextBox", LocationSearchBox) as TextBox;
            if (SearchField != null)
            {
                SearchField.Focus();
            }

            if (String.IsNullOrEmpty(LocationSearchBox.Text))
            {
                GoButton.Opacity = 0.25;
                ClearAllButton.Visibility = Visibility.Collapsed;
            }
        }

        private void LocationSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Views.DiseaseInfoWindow secondWindow = new Views.DiseaseInfoWindow(((ComboBox)sender).Text);
                secondWindow.Owner = this;
                secondWindow.Show();
            }
            else if (String.IsNullOrEmpty(((ComboBox)sender).Text) || e.Key == Key.Escape)
            {
                ((ComboBox)sender).IsDropDownOpen = false;
            }
            else if (!((ComboBox)sender).IsDropDownOpen)
            {
                TextBox textBoxBase = (TextBox)((ComboBox)sender).Template.FindName("PART_EditableTextBox", (ComboBox)sender);
                int previousSelectionLength = textBoxBase.SelectionLength;

                ((ComboBox)sender).IsDropDownOpen = true;
                textBoxBase.SelectionStart = textBoxBase.Text.Length - previousSelectionLength;
                textBoxBase.SelectionLength = previousSelectionLength;
            }
        }

        private void LocationSearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(((ComboBox)sender).Text))
            {
                GoButton.Opacity = 0.25;
                ClearAllButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                GoButton.Opacity = 1;
                ClearAllButton.Visibility = Visibility.Visible;
            }
        }

        private void ClearAllButton_Click(object sender, RoutedEventArgs e)
        {
            var SearchField = LocationSearchBox.Template.FindName("PART_EditableTextBox", LocationSearchBox) as TextBox;
            SearchField.Clear();
        }

        private void AdminOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            // Test login window
            Views.AdminLoginWindow loginWindow = new Views.AdminLoginWindow();
            loginWindow.Owner = this;
            loginWindow.ShowDialog();
        }
    }
}

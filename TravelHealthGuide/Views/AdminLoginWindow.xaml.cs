using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TravelHealthGuide.Views
{
    /// <summary>
    /// Interaction logic for AdminLoginWindow.xaml
    /// </summary>
    public partial class AdminLoginWindow : Window
    {
        public AdminLoginWindow()
        {
            InitializeComponent();
        }

        //FIXME
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminOptionsWindow w = new AdminOptionsWindow();
            w.Owner = Application.Current.MainWindow;
            w.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}

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
using TravelHealthGuide.ViewModels;

namespace TravelHealthGuide.Views
{
    /// <summary>
    /// Interaction logic for AdminLoginWindow.xaml
    /// </summary>
    public partial class AdminLoginWindow : Window
    {
        private readonly AdminLoginViewModel _viewmodel;

        public AdminLoginWindow()
        {
            InitializeComponent();
            _viewmodel = new AdminLoginViewModel();
            this.DataContext = _viewmodel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewmodel.Authenticate(PasswordField.Password);
            //AdminOptionsWindow w = new AdminOptionsWindow();
            //w.Owner = Application.Current.MainWindow;
            //w.ShowDialog();
            //this.Hide();
            //this.Close();
        }
    }
}

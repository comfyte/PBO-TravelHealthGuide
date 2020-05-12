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
    /// Interaction logic for AdminOptionsWindow.xaml
    /// </summary>
    public partial class AdminOptionsWindow : Window
    {
        public AdminOptionsWindow()
        {
            InitializeComponent();
        }

        private void AdminOptionsWindow_OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Log out from admin console?", "Exit confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            if (result == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Owner.Focus();
            }
        }
    }
}

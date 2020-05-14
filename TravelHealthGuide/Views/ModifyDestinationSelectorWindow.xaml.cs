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
    /// Interaction logic for ModifyDestinationSelectorWindows.xaml
    /// </summary>
    public partial class ModifyDestinationSelectorWindow : Window
    {
        private readonly ModifyDestinationSelectorViewModel _viewmodel;
        public ModifyDestinationSelectorWindow()
        {
            InitializeComponent();
            _viewmodel = new ModifyDestinationSelectorViewModel();
            this.DataContext = _viewmodel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewmodel.Proceed();
            this.Close();
        }
    }
}

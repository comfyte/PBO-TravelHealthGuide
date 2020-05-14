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
    /// Abstract class untuk diturunkan ke RemoveDiseaseEntryWindow dan RemoveUserEntryWindow
    /// </summary>
    public abstract partial class RemoveDatabaseEntryWindowBase : Window
    {
        public RemoveDatabaseEntryWindowBase()
        {
            InitializeComponent();
            MessageBox.Show("Yo, I, the base, am still executed!");
        }
    }
}

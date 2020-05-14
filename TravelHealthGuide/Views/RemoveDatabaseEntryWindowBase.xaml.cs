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
        //public Binding ItemsSourceBinding { get; protected set; }

        public RemoveDatabaseEntryWindowBase()
        {
            InitializeComponent();
            //MessageBox.Show("Yo, I, the base, am still executed!");
        }

        protected GridViewColumn GenerateColumns(string header, int width, string displayMemberBinding)
        {
            GridViewColumn GVC = new GridViewColumn();
            GVC.Header = header;
            GVC.Width = width;
            GVC.DisplayMemberBinding = new Binding(displayMemberBinding);
            return GVC;
        }

        protected void AddColumns(List<GridViewColumn> Items)
        {
            foreach (GridViewColumn column in Items)
            {
                TableView.Columns.Add(column);
            }
        }

        protected abstract void RemoveButton_Click(object sender, RoutedEventArgs e);

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

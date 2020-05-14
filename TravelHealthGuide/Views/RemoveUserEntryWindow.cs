using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TravelHealthGuide.Models.DatabaseModels;
using TravelHealthGuide.ViewModels;

namespace TravelHealthGuide.Views
{
    public class RemoveUserEntryWindow : RemoveDatabaseEntryWindowBase
    {
        private readonly RemoveUserEntryViewModel _viewmodel;

        public RemoveUserEntryWindow() : base()
        {
            _viewmodel = new RemoveUserEntryViewModel();
            this.DataContext = _viewmodel;

            //ItemsSourceBinding = new Binding("DataSource");

            base.AddColumns(new List<GridViewColumn>
            {
                base.GenerateColumns("ID", 30, "UserID"),
                base.GenerateColumns("Username", 200, "Username")
            });
        }

        protected override void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            bool Complete = _viewmodel.RemoveSelected();
            if (Complete)
            {
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using TravelHealthGuide.ViewModels;

namespace TravelHealthGuide.Views
{
    public class RemoveDiseaseEntryWindow : RemoveDatabaseEntryWindowBase
    {
        private RemoveDiseaseEntryViewModel _viewmodel;

        public RemoveDiseaseEntryWindow() : base()
        {
            _viewmodel = new RemoveDiseaseEntryViewModel();
            this.DataContext = _viewmodel;
        }

        protected override void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

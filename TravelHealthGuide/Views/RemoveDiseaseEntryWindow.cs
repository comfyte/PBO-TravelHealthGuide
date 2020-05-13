using System;
using System.Collections.Generic;
using System.Text;
using TravelHealthGuide.ViewModels;

namespace TravelHealthGuide.Views
{
    public partial class RemoveDiseaseEntryWindow : RemoveDatabaseEntryWindowBase
    {
        private RemoveDiseaseEntryViewModel _viewmodel;

        public RemoveDiseaseEntryWindow() : base()
        {
            _viewmodel = new RemoveDiseaseEntryViewModel();
            this.DataContext = _viewmodel;
        }
    }
}

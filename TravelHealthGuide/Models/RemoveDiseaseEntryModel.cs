using System;
using System.Collections.Generic;
using System.Text;
using TravelHealthGuide.Models.DatabaseModels;

namespace TravelHealthGuide.Models
{
    public class RemoveDiseaseEntryModel
    {
        public void RemoveItem(DestinationInfo item)
        {
            using (var db = new DataBase())
            {
                db.Remove(item);
                db.SaveChanges();
            }
        }
    }
}

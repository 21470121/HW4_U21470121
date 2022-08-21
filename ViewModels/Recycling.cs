using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.ViewModels
{
    public class Recycling : Volunteer
    {
        ////public string Name { get; set; }
        ////public string Surname { get; set; }

        ////public string CellNumber { get; set; }
        public string WasteType { get; set; }
        public int EstimatedWeight { get; set; }

        public DateTime PickUpDate { get; set; }

        public Recycling(string name, string surname, string cellnumber, string wastetype, int estWaste, DateTime pickup): base(name, surname, cellnumber)
        {
            WasteType = wastetype;
            EstimatedWeight = estWaste;
            PickUpDate = pickup;
        }

        public override string Info()
        {
            return base.Info() + " voluntered to donate " + EstimatedWeight + " kg of " + WasteType + ".";
        }
    }
}
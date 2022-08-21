using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.ViewModels
{
    public class HOPE: Volunteer
    {
        private string Type { get; set; }

        public HOPE(string name, string surname, string cellnumber, string type): base(name, surname, cellnumber)
        {
            Type = type;
        }
    }
}
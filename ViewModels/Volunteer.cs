using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.ViewModels
{
    public abstract class Volunteer
    {
       private string Name { get; set; }
        private string Surname { get; set; }
        private string CellNumber { get; set; }

        public Volunteer(string name, string surname, string cellnumber)
        {
            Name = name;
            Surname = surname;
            CellNumber = cellnumber;
        }

        public virtual string Info()
        {
            return Name + " " + Surname;
        }

    }
}
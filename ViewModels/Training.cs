using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.ViewModels
{
    public class Training: Volunteer
    {
        private string TrainingType {get;set;}
        private string TrainingDescrip{ get; set; }

        public Training(string name, string surname, string cellnumber, string trtype, string trdescrip): base(name, surname, cellnumber)
        {
            TrainingType = trtype;
            TrainingDescrip = trdescrip;
        }

        public override string Info()
        {
            return base.Info() + " " + TrainingType;
        }
    }
}
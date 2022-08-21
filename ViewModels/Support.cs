using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.ViewModels
{
    public class Support: HOPE
    {
        private Decimal AmountDonated { get; set; }
        private string SupportFor { get; set; }

        public Support(string name, string surname, string cellnumber, string type, decimal amount, string Sfor): base(name, surname,cellnumber, type)
        {
            AmountDonated = amount;
            SupportFor= Sfor;
        }
    }

}
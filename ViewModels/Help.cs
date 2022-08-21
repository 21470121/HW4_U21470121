using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.ViewModels
{
    public class Help: HOPE
    {
        
        private string HelpWith { get; set; }

        public Help(string name, string surname, string cellnumber, string type, string helpwith) : base(name, surname, cellnumber, type)
        {
            HelpWith= helpwith;
        }
    }
}
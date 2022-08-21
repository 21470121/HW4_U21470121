using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class HOPEController : Controller
    {
        // GET: HOPE
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Help()
        {
            return View();
        }

        public ActionResult Support()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Support(string SName, string SSur, string SCell, decimal SDonated, string SFor)
        {
            List<ViewModels.Support> supports = new List<ViewModels.Support>();
            ViewModels.Support support1 = new ViewModels.Support(SName, SSur, SCell,"Support", SDonated, SFor);
            supports.Add(support1);
            return View();
        }

        public ActionResult Help(string HName, string HSur, string HCell, string HType)
        {
            List<ViewModels.Help> supports = new List<ViewModels.Help>();
            ViewModels.Help help1 = new ViewModels.Help(HName, HSur, HCell, "Help", HType);
            supports.Add(help1);
            return View();
        }
    }
}
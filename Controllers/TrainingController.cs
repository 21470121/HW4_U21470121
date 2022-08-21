using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class TrainingController : Controller
    {
        // GET: Training
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormResult()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string TrName, string TrSur, string TrCell, string TrType, string TrDescription)
        {
            List<ViewModels.Training> trainings = new List<ViewModels.Training>();
            ViewModels.Training training1 = new ViewModels.Training(TrName, TrSur, TrCell, TrType, TrDescription);
            trainings.Add(training1);
            ViewBag.Name = TrName + " " + TrSur;
            return View();
        }
    }
}
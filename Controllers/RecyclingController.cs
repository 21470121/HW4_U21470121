using HW4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class RecyclingController : Controller
    {
        // GET: Recycling
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormResult()
        {
            List<ViewModels.Recycling> recyclings = RecyclingInfo();

            return View(recyclings);
        }
        private List<ViewModels.Recycling> RecyclingInfo()
        {
            List<ViewModels.Recycling> RecyclingModel = new List<ViewModels.Recycling>();
            ViewModels.Recycling recycling1 = new ViewModels.Recycling("Sam", "van whyk", "058369884", "Paper", 3, new DateTime(2022, 12, 25));
            ViewModels.Recycling recycling2 = new ViewModels.Recycling("Jenny", "Burnett", "068298788", "Glass", 25, new DateTime(2022, 11, 15));
            ViewModels.Recycling recycling3 = new ViewModels.Recycling("Kim", "Louw", "0585559884", "Metal", 6, new DateTime(2022, 12, 11));
            ViewModels.Recycling recycling4 = new ViewModels.Recycling("Mary", "Ndlovu", "058389884", "Plastic", 12, new DateTime(2022, 10, 16));
            ViewModels.Recycling recycling5 = new ViewModels.Recycling("Yasemin", "Govender", "058369884", "Paper", 5, new DateTime(2022, 12, 25));
            RecyclingModel.Add(recycling1);
            RecyclingModel.Add(recycling2);
            RecyclingModel.Add(recycling3);
            RecyclingModel.Add(recycling4);
            RecyclingModel.Add(recycling5);
            return RecyclingModel;
        }

        [HttpPost]
        public ActionResult Index(string Recname, string RecSur, string RecCell, string RecWaste, int RecEstimated, DateTime RecPickUp)
        {
            
            List<ViewModels.Recycling> recyclings = new List<ViewModels.Recycling>();
            ViewModels.Recycling recyclings1 = new ViewModels.Recycling(Recname, RecSur, RecCell, RecWaste, RecEstimated, RecPickUp);
            recyclings.Add(recyclings1);
            ViewBag.Name = Recname + " " + RecSur; 
            return View("FormResult");
        }



    
    }
}
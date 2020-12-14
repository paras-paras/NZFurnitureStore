using NZFurnitureStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NZFurnitureStore.Controllers
{
    public class HomeController : Controller
    {

        NZFurnitureEntities nZFurniture = new NZFurnitureEntities();

        // GET: Product
        public ActionResult ManageQuery()
        {
            return View(nZFurniture.QuerySections.ToList());
        }
        // GET: Product/Delete/5
        public ActionResult Delete(QuerySection qry)
        {
            var d = nZFurniture.QuerySections.Where(x => x.id == qry.id).FirstOrDefault();
            nZFurniture.QuerySections.Remove(d);
            nZFurniture.SaveChanges();
            return RedirectToAction("ManageQuery");

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult blog()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult approval()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult PassQuery(Query contact)
        {
            //generate the query to check the user name or passwod
            if (contact.Insert() == 1)
            {
                return View("approval");
            }
            else
            {
                return View();
            }



        }


    }
}
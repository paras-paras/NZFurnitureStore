using NZFurnitureStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NZFurnitureStore.Controllers
{
    public class SalaryController : Controller
    {

        NZFurnitureEntities nZFurniture = new NZFurnitureEntities();

        // GET: Product
        public ActionResult ManagePayment()
        {
            return View(nZFurniture.Salaries.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Salary payment)
        {
            if (!ModelState.IsValid)
                return View();
            nZFurniture.Salaries.Add(payment);
            nZFurniture.SaveChanges();
            return RedirectToAction("ManagePayment");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {

            var IdToEdit = (from m in nZFurniture.Salaries where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Salary payment)
        {
            var orignalRecord = (from m in nZFurniture.Salaries where m.id == payment.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            nZFurniture.Entry(orignalRecord).CurrentValues.SetValues(payment);

            nZFurniture.SaveChanges();
            return RedirectToAction("ManagePayment");
        }

        // GET: Product/Delete/5
        public ActionResult Delete(Salary payment)
        {
            var d = nZFurniture.Salaries.Where(x => x.id == payment.id).FirstOrDefault();
            nZFurniture.Salaries.Remove(d);
            nZFurniture.SaveChanges();
            return RedirectToAction("ManagePayment");

        }



        // POST: Salary/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

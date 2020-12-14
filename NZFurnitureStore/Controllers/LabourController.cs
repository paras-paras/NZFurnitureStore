using NZFurnitureStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NZFurnitureStore.Controllers
{
    public class LabourController : Controller
    {
        NZFurnitureEntities nZFurniture = new NZFurnitureEntities();

        // GET: Product
        public ActionResult ManageStaff()
        {
            return View(nZFurniture.Labours.ToList());
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
        public ActionResult Create(Labour Staff)
        {
            if (!ModelState.IsValid)
                return View();
            nZFurniture.Labours.Add(Staff);
            nZFurniture.SaveChanges();
            return RedirectToAction("ManageStaff");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {

            var IdToEdit = (from m in nZFurniture.Labours where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Labour staff)
        {
            var orignalRecord = (from m in nZFurniture.Labours where m.id ==staff.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            nZFurniture.Entry(orignalRecord).CurrentValues.SetValues(staff);

            nZFurniture.SaveChanges();
            return RedirectToAction("ManageStaff");
        }

        // GET: Product/Delete/5
        public ActionResult Delete(Labour labour)
        {
            var d = nZFurniture.Labours.Where(x => x.id ==labour.id).FirstOrDefault();
            nZFurniture.Labours.Remove(d);
            nZFurniture.SaveChanges();
            return RedirectToAction("ManageStaff");

        }




        // POST: Labour/Delete/5
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

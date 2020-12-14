using NZFurnitureStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NZFurnitureStore.Controllers
{
    public class ProductController : Controller
    {
        NZFurnitureEntities nZFurniture = new NZFurnitureEntities();

        // GET: Product
        public ActionResult ManageProduct()
        {
            return View(nZFurniture.Products.ToList());
        }


        public ActionResult viewProduct()
        {
            return View(nZFurniture.Products.ToList());
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
        public ActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
                return View();
            nZFurniture.Products.Add(product);
            nZFurniture.SaveChanges();
            return RedirectToAction("ManageProduct");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {

            var IdToEdit = (from m in nZFurniture.Products where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            var orignalRecord = (from m in nZFurniture.Products where m.id == product.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            nZFurniture.Entry(orignalRecord).CurrentValues.SetValues(product);

            nZFurniture.SaveChanges();
            return RedirectToAction("ManageProduct");
        }

        // GET: Product/Delete/5
        public ActionResult Delete(Product product)
        {
            var d = nZFurniture.Products.Where(x => x.id == product.id).FirstOrDefault();
            nZFurniture.Products.Remove(d);
            nZFurniture.SaveChanges();
            return RedirectToAction("ManageProduct");

        }

        // POST: Product/Delete/5
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

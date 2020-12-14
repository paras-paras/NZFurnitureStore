using NZFurnitureStore.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NZFurnitureStore.Controllers
{
    public class HeadController : Controller
    {
       

        // GET: Head
        public ActionResult headLogin()
        {
            return View();
        }
        // GET: Head
        public ActionResult headPannel()
        {
            return View();
        }

        // GET: Head
        public ActionResult invalidPannel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult headCheck(headID Login_Block)
        {
            //generate the query to check the user name or passwod
         
            int x = Login_Block.loginVerfication();
            if (x > 0)
            {
                return View("headPannel");
            }
            else
            {
                return View("InvalidPannel");
            }


        }




    }
}
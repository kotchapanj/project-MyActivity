using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAdventure.Controllers
{
    public class ActivityController : Controller
    {
        // GET: Activity
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Details()
        {
            return View();
        }


     
        public ActionResult Create(string param1)
        {
            string x = "";

            return View();

        }




    }
}
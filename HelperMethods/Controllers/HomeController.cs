﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperMethods.Models;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] { "Apple","Orange","Pear"};
            ViewBag.Cities = new string[] { "New York","London","Paris"};
            string message = "This is an HTML element:<input>";
            return View((object)message);
        }

        public ActionResult CreatePerson()
        {
            return View(new Person());
        }

        //[HttpPost]
        //public ActionResult CreatePerson(Person person)
        //{
        //    return View(person);
        //}

        [HttpPost]
        public ActionResult CreatePerson(Person person)
        {
            return View("DisplayPerson",person);
        }
    }
}
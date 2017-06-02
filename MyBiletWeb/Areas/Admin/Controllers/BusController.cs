using BusinessLayer;
using Entity;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBiletWeb.Areas.Admin.Controllers
{
    public class BusController : Controller
    {
        BusBusiness busBLL = new BusBusiness();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Bus bus)
        {
            BusValidation validator = new BusValidation();
            ValidationResult results = validator.Validate(bus);  
            if (results.IsValid)
            {
                if (busBLL.AddBus(bus))
                {
                    TempData["Success"] = true;
                }
                else
                {
                    TempData["Success"] = false;
                }

                return View();
            }
            else {
                foreach (var error in results.Errors)
                { 
                }
                TempData["Error"] = results.Errors;
                return View(bus);
            }

          
        }


    }
}
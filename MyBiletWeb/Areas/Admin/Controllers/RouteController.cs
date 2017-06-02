using BusinessLayer;
using Entity;
using Entity.Validation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBiletWeb.Areas.Admin.Controllers
{
    public class RouteController : Controller
    {
        // GET: Admin/Route
        RouteBusiness routeBll = new RouteBusiness();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
        
            return View(routeBll.GetAllCity());
        }

        // POST: Admin/City/Create
        [HttpPost]
        public ActionResult Create(Route item)
        {
            RouteValidation validator = new RouteValidation();
            ValidationResult results = validator.Validate(item);
            if (results.IsValid)
            {
                if (routeBll.AddRoute(item))
                {
                    TempData["Success"] = true;
                }
                else
                {
                    TempData["Success"] = false;
                }

                return View(routeBll.GetAllCity());
            }
            else
            {
                foreach (var error in results.Errors)
                {
                }
                TempData["Error"] = results.Errors;
                return View(item);
            }


        }
    }
}
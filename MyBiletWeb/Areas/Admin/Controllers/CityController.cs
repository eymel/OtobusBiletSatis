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
    public class CityController : Controller
    {
        CityBusiness cityBLL = new CityBusiness();
        // GET: Admin/City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/City/Create
        [HttpPost]
        public ActionResult Create(City city)
        {
            CityValidation validator = new CityValidation();
            ValidationResult results = validator.Validate(city);
            if (results.IsValid)
            {
                if (cityBLL.CityAdd(city))
                {
                    TempData["Success"] = true;
                }
                else
                {
                    TempData["Success"] = false;
                }

                return View();
            }
            else
            {
                foreach (var error in results.Errors)
                {
                }
                TempData["Error"] = results.Errors;
                return View(city);
            }


        }

        // GET: Admin/City/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/City/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/City/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/City/Delete/5
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

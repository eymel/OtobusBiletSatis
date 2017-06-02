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
    public class ScheduleController : Controller
    {
        ScheduleBusinees scheduleBLL = new ScheduleBusinees();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            scheduleBLL.FillForm();


            return View(
            scheduleBLL.FillForm());
        }

        // POST: Admin/City/Create
        [HttpPost]
        public ActionResult Create(Schedule item)
        {
            ScheduleValidation validator = new ScheduleValidation();
            ValidationResult results = validator.Validate(item);
            if (results.IsValid)
            {
                if (scheduleBLL.AddSchedule(item))
                {
                    TempData["Success"] = true;
                }
                else
                {
                    TempData["Success"] = false;
                }

                return View(scheduleBLL.FillForm());
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


        public ActionResult SearchSchedule()
        {
            return View(scheduleBLL.GetAllCity());
        }
        [HttpPost]
        public ActionResult SearchSchedule(int departureCity,int DestirationCity , string DepartureDate)
        {
             List<Schedule> schedules= scheduleBLL.GetScheduleAll(departureCity, DestirationCity, DepartureDate);
            if (schedules.Count>0)
            {
            return PartialView("ScheduleList",schedules);
            }
            else
            {
                return HttpNotFound();
            }

        }
       



    }
}
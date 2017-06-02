using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBiletWeb.Areas.Admin.Models
{
    public class ScheduleModel
    {
        public List<Bus> Bus { get; set; }
        public List<Route> Route { get; set; }
        public List<ScheduleTime> ScheduleTime { get; set; }

    }
}
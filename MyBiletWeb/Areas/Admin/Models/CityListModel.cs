using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBiletWeb.Areas.Admin.Models
{
    public class CityListModel
    {
        public string SelectedItemId { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }
    }
}
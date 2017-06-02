using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Hatalar
{
    class Hata
    {
    }
    public class RouteNull : Exception
    {
        public RouteNull():base("Rota Bulunamadı")
        {

        }
    }
    public class ScheduleNotFound : Exception
    {
        public ScheduleNotFound() : base("Sefer Bulunamadı ")
        {

        }
    }
  
}

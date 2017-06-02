using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Route
    {
        public int ID { get; set; }
        public string Name
        {
            get
            {
                return string.Format("{0} - {1} Seferi ", DeparturePoint.CityName, Destiration.CityName);
            }
        }
        public decimal Price { get; set; }
        public int DeparturePointID { get; set; }
        public int DestirationID { get; set; }

        public virtual City DeparturePoint { get; set; }
        public virtual City Destiration { get; set; }
    }
}

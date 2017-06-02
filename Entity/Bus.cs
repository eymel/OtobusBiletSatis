using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Bus
    {
        public int BusID { get; set; }
        public string PlateNumber { get; set; }
        public BusType BusType { get; set; }

        public int Capacity { get; set; }

        

    }
public enum BusType
{
    Economics,Business
}
}

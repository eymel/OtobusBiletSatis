using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Map
{
    public class BusMap:EntityTypeConfiguration<Bus>
    {
        public BusMap()
        {
            HasKey(x => x.BusID);
   
        
 
        }
    }
}

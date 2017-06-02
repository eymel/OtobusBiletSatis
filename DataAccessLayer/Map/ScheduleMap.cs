using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Map
{
   public class ScheduleMap:EntityTypeConfiguration<Schedule>
    {
        public ScheduleMap()
        {
            HasKey(x => x.ScheduleID);
            Ignore(x=>x.GetSeatList);
        
            

            HasRequired(x => x.Bus).WithMany().HasForeignKey(x => x.BusID);
            HasRequired(x => x.ScheduleTime).WithMany().HasForeignKey(x => x.ScheduleTimeID);
            HasRequired(x => x.Route).WithMany().HasForeignKey(x => x.RouteID);
        }
    }
}

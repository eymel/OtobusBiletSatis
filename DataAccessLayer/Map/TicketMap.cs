using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Map
{
   public class TicketMap:EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            HasKey(x => x.TicketID);
            Ignore(x => x.Status);
            HasRequired(x => x.Schedule).WithMany(t=>t.Tickets).HasForeignKey(x => x.ScheduleID);
            HasRequired(x => x.Customer).WithMany().HasForeignKey(x => x.CustomerID);

        }
    }
}

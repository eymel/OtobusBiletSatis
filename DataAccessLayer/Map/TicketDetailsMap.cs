using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Map
{
    public class TicketDetailsMap : EntityTypeConfiguration<TicketDetail>
    {
        public TicketDetailsMap()
        {
            HasKey(x => x.ID);
            HasRequired(x=>x.Ticket).WithMany(t=>t.TicketDetails).HasForeignKey(x=>x.TicketID);

        }
    }
}

using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
   public class TicketRepository:BaseRepository<Ticket>
    {
        public TicketRepository(MyTicketContext context):base(context)
        {

        }
        public List<Ticket> GetScheduleTickets(int scheduleID)
        {
            return _context.Set<Ticket>().Where(x => x.ScheduleID == scheduleID).OrderBy(x=>x.SeatNumber).ToList();
        }
    }
}

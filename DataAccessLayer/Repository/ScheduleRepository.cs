using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ScheduleRepository:BaseRepository<Schedule>
    {
        public ScheduleRepository(MyTicketContext context):base(context)
        {

        }
        public List<Schedule> GetByRouteID(int routeID)
        {
          return  _context.Set<Schedule>().Where(x=>x.RouteID==routeID).ToList();
        }
    }
}

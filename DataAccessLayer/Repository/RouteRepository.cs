using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class RouteRepository:BaseRepository<Route>
    {
        public RouteRepository(MyTicketContext context):base(context)
        {

        }
        public Route Search(int departureCityID, int destinationCityID)
        {
            return _context.Set<Route>().Where(x=>x.DeparturePointID==departureCityID && x.DestirationID==destinationCityID).FirstOrDefault();
        }
    }
}

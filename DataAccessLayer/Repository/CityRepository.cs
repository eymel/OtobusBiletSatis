using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CityRepository:BaseRepository<City>
    {
        public CityRepository(MyTicketContext context):base(context)
        {

        }
        public City GetCitybyName(string name)
        {
            return _context.Set<City>().Where(x => x.CityName == name).FirstOrDefault();
        }
    }
}
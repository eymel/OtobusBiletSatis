using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BusRepository : BaseRepository<Bus>
    {
        public BusRepository(MyTicketContext context) : base(context)
        {

        }
    }
}

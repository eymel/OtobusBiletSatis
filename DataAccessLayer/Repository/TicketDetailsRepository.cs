using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class TicketDetailsRepository:BaseRepository<TicketDetail>
    {
        public TicketDetailsRepository(MyTicketContext context):base(context)
        {

        }
    }
}

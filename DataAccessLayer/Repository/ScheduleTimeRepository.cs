using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ScheduleTimeRepository:BaseRepository<ScheduleTime>
    {
        public ScheduleTimeRepository(MyTicketContext context):base(context)
        {

        }
    }
}

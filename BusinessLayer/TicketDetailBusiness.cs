using DataAccessLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TicketDetailBusiness
    {
        UnitOfWork _db;
        public TicketDetailBusiness()
        {
            _db = new UnitOfWork();
        }


        public bool AddTicketDetail(TicketDetail ticketdetail)
        {
            _db.TicketDetailsRepository.Add(ticketdetail);
            return _db.ApplyChanges();
        }

    }

}

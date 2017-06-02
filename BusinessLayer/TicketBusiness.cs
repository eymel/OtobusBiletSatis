using DataAccessLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TicketBusiness
    {
        UnitOfWork _db;
        public TicketBusiness()
        {
            _db = new UnitOfWork();
        }
        TicketDetailBusiness _tDetailBll = new TicketDetailBusiness();
        public bool AddTicket(Ticket ticket) {

            _db.TicketRepository.Add(ticket);

            TicketDetail ticketdetail = new TicketDetail();
            ticketdetail.TicketID = ticket.TicketID;
            ticketdetail.ActionDate = DateTime.Now;
            ticketdetail.ActionType = TicketStatus.Sold;
            _tDetailBll.AddTicketDetail(ticketdetail);
            return _db.ApplyChanges();
            
        }
        public bool RezerveTicket(Ticket ticket)
        {

            _db.TicketRepository.Add(ticket);

            TicketDetail ticketdetail = new TicketDetail();
            ticketdetail.TicketID = ticket.TicketID;
            ticketdetail.ActionDate = DateTime.Now;
            ticketdetail.ActionType = TicketStatus.Rezerve;
            _tDetailBll.AddTicketDetail(ticketdetail);
            return _db.ApplyChanges();

        }
        public bool UpdateTicket(int ticketID,TicketStatus ticketStatus)
        {

           

            TicketDetail ticketdetail = new TicketDetail();
            ticketdetail.TicketID =ticketID;
            ticketdetail.ActionDate = DateTime.Now;
            ticketdetail.ActionType = ticketStatus;
            _tDetailBll.AddTicketDetail(ticketdetail);
            return _db.ApplyChanges();

        }


        public List<Ticket> TicketControlByScheduleID(int scheduleID)
        {
           return _db.TicketRepository.GetScheduleTickets(scheduleID);
          
        }
    }
}

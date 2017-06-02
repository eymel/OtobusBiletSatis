using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ticket
    {
        public Ticket()
        {
            TicketDetails = new List<TicketDetail>();
        }
        public int TicketID { get; set; }
        public int ScheduleID { get; set; }
        public int CustomerID { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }

        public string PnrNumber { get; set; }
        public TicketStatus Status
        {
            get
            {
                if (TicketDetails.Count>0)
                {

                    TicketDetail lastAction = this.TicketDetails.OrderByDescending(th => th.ActionDate).First();
                    return lastAction.ActionType;
                }
                else
                {
                    return TicketStatus.None;
                }
            }
        }


        public Schedule Schedule { get; set; }
        public User Customer { get; set; }
        public List<TicketDetail> TicketDetails { get; set; }

    }
}

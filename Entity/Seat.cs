using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Seat
    {

        public Seat(Ticket ticket)
        {
            if (ticket.Status==TicketStatus.None)
            {
                Status = false;
            }
            else
            {
                Status = true;
            }

        }
        public int NumberOfSeat { get; set; }
        public Ticket Ticket { get; set; }
        public bool Status { get; set; }
     


    }


}

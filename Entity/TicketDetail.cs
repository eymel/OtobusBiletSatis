using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TicketDetail
    {

        public int ID { get; set; }
        public int TicketID { get; set; }
        public DateTime ActionDate { get; set; }
        public TicketStatus ActionType { get; set; }



        public Ticket Ticket { get; set; }
    }
    public enum TicketStatus
    {
        None = 0,
        Empty,
        Sold,
        Rezerve,

    }
}

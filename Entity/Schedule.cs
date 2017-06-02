using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Schedule
    {

        public Schedule()
        {
          

            Tickets = new HashSet<Ticket>();
            _seatList = new List<Seat>();
        }

        private List<Seat> _seatList;
      
        public int ScheduleID { get; set; }
        public DateTime DepartureTime { get; set; }
        public int BusID { get; set; }
        public int RouteID { get; set; }

        public int ScheduleTimeID { get; set; }
        public virtual ScheduleTime ScheduleTime { get; set; }

        public virtual Route Route { get; set; }
        public virtual Bus Bus { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }


        public void KoltuklarıDoldur()
        {

            for (int i = 0; i < Bus.Capacity; i++)
            {
                Seat seat = new Seat(new Ticket());
                _seatList.Add(seat);
            }
        }
        public List<Seat> GetSeatList
        {
            get
            {
                return _seatList;
            }

        }
    }
}

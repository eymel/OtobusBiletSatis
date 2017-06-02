using BusinessLayer.Hatalar;
using DataAccessLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ScheduleBusinees
    {

        UnitOfWork _db;
        public ScheduleBusinees()
        {
            _db = new UnitOfWork();
        }
        TicketBusiness _ticketBll = new TicketBusiness();
        RouteBusiness _routeBll = new RouteBusiness();
        BusBusiness _busBll = new BusBusiness();
        CityBusiness _cityBll = new CityBusiness();
        public List<Seat> GetSeat(int scheduleID)
        {
            try
            {

                Schedule schedule = _db.ScheduleRepository.Get(scheduleID);

                if (schedule != null)
                {

                    bool seatControl = false;
                    schedule.KoltuklarıDoldur();

                    List<Ticket> listSeat = _ticketBll.TicketControlByScheduleID(schedule.ScheduleID);
                    for (int i = 0; i < schedule.GetSeatList.Count; i++)
                    {
                        if (listSeat.Count > 0)
                        {
                            foreach (var item in listSeat)
                            {
                                if (item.Status != TicketStatus.Empty && item.Status != TicketStatus.None && item.SeatNumber == i + 1)
                                {
                                    schedule.GetSeatList[i].Ticket.SeatNumber = item.SeatNumber;
                                    schedule.GetSeatList[i].Ticket = item;
                                    schedule.GetSeatList[i].Status = true;
                                    seatControl = true;
                                    break;
                                }
                            }
                        }


                        if (seatControl == false)
                        {
                            schedule.GetSeatList[i].NumberOfSeat = i + 1;
                            schedule.GetSeatList[i].Status = false;
                        }


                    }


                }
                else
                {
                    throw new ScheduleNotFound();
                }



                return schedule.GetSeatList;
           



            }
            catch (ScheduleNotFound)
            {
                throw new ScheduleNotFound();
            }
            catch (RouteNull)
            {
                throw new RouteNull();
            }
            catch (Exception)
            {

                throw;
            }







        }
        public List<Schedule> GetScheduleAll(int departureCityID, int destinationCityID, string departureDate)
        {

    int routeID = _routeBll.GetRouteID(departureCityID, destinationCityID);

    List<Schedule> schedule = _db.ScheduleRepository.GetByRouteID(routeID);
            var listschedule = (from sc in schedule where sc.DepartureTime.ToShortDateString() == departureDate select sc).ToList();

           
            if (listschedule!=null)
            {
                return listschedule;
            }
            else
            {
                throw new ScheduleNotFound();
            }

    }
        public bool AddSchedule(Schedule schedule)
        {
            _db.ScheduleRepository.Add(schedule);
            return _db.ApplyChanges();
        }

        public ScheduleModel FillForm()
        {
            ScheduleModel scheduleModel = new ScheduleModel();
            scheduleModel.Bus= _busBll.GetAll();
            scheduleModel.Route = _routeBll.GetAllRoute();
            scheduleModel.ScheduleTime = _db.ScheduleTimeRepository.GetAll();
            return scheduleModel;
        }
        public List<City> GetAllCity()
        {
            return _cityBll.GetAll();
        }




    }
}

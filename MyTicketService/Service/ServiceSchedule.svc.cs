using BusinessLayer;
using Entity;
using MyTicketService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyTicketService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceSchedule" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceSchedule.svc or ServiceSchedule.svc.cs at the Solution Explorer and start debugging.
    public class ServiceSchedule : IServiceSchedule
    {
        public List<ScheduleModel> GetSchuleAll(int departureCityID, int destinationCityID, string departureDate)
        {
            ScheduleBusinees _sBll = new ScheduleBusinees();
            List<Schedule> listSchedule = _sBll.GetScheduleAll(departureCityID, destinationCityID, departureDate);
            List<ScheduleModel> _listModel = listSchedule.Select(
                x => new ScheduleModel
                {
                    ScheduleID = x.ScheduleID,
                    RouteName = x.Route.Name,
                    DepartureTime = x.DepartureTime.ToShortDateString(),
                    ScheduleTime = x.ScheduleTime.Time.ToString()

                }


                ).ToList();


            return _listModel;


        }
    }
}

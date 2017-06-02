using MyTicketService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyTicketService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceSchedule" in both code and config file together.
    [ServiceContract]
    public interface IServiceSchedule
    {
        [OperationContract]
        List<ScheduleModel> GetSchuleAll(int departureCityID, int destinationCityID, string departureDate);
    }
}

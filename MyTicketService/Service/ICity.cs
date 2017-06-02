using MyTicketService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyTicketService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICity" in both code and config file together.
    [ServiceContract]
    public interface ICity
    {
        [OperationContract]
        List<CityModel> GetAll();
        [OperationContract]
        CityModel GetCityId(string name);
    }
}

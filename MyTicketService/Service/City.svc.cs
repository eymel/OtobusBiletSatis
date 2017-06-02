using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyTicketService.Model;
using BusinessLayer;

namespace MyTicketService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "City" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select City.svc or City.svc.cs at the Solution Explorer and start debugging.
    public class City : ICity
    {
        CityBusiness cityBll = new CityBusiness();
        public List<CityModel> GetAll()
        {
          List<Entity.City> city=  cityBll.GetAll();

            List<CityModel> citymodel = city.Select(x=>new CityModel { ID=x.CityID,Name=x.CityName}).ToList();

            return citymodel;
        }

    
        public CityModel GetCityId(string name)
        {
            Entity.City city = cityBll.GetCityByName(name);
            if (city!=null)
            {
                CityModel citymodel = new CityModel { ID = city.CityID, Name = city.CityName };
                return citymodel;
            }
            return null;

            
        }
    }
}

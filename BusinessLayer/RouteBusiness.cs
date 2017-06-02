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
   public  class RouteBusiness
    {
        UnitOfWork _db;
        public RouteBusiness()
        {
            _db = new UnitOfWork();
        }
        CityBusiness cityBLL = new CityBusiness();
        public int GetRouteID(int departureCityID , int destinationCityID)
        {
            Route route = _db.RouteRepository.Search(departureCityID,destinationCityID);
            if (route!=null)
            {
            return route.ID;
            }
            else
            {
                throw new RouteNull();
            }
        }
        public bool AddRoute(Route route)
        {
            _db.RouteRepository.Add(route);
            return _db.ApplyChanges();
        }
        public List<Route> GetAllRoute() {

            return _db.RouteRepository.GetAll();
        }
        public List<City> GetAllCity()
        {
           return cityBLL.GetAll();
        }

    }
}

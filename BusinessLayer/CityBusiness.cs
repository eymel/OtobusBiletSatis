using DataAccessLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CityBusiness
    {
        UnitOfWork _db;
        public CityBusiness()
        {

            _db = new UnitOfWork();
        }

        public bool CityAdd(City city)
        {
            _db.CityRepository.Add(city);
            return _db.ApplyChanges();
        }
        public List<City> GetAll()
        {
            return _db.CityRepository.GetAll();
        }
        public City GetCityByName(string name)
        {
            return _db.CityRepository.GetCitybyName(name);
        }
    }
}

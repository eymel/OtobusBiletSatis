using DataAccessLayer;

using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusBusiness
    {
        UnitOfWork _db;
        public BusBusiness()
        {
            _db = new UnitOfWork();
        }

        public bool AddBus(Bus bus)
        {
            _db.BusRepository.Add(bus);
            return _db.ApplyChanges();
        }
        public List<Bus> GetAll()
        {
            return _db.BusRepository.GetAll();

        }
        public bool DeleteBus(Bus bus)
        {
            _db.BusRepository.Delete(bus);
            return _db.ApplyChanges();
        }


    }
}

using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class CustomerBusiness
    {
        UnitOfWork _db;
        public CustomerBusiness()
        {
            _db = new UnitOfWork();
        }
        
    }
}

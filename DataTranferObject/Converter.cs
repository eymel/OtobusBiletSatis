using AutoMapper;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
   public static class Converter
    {
        public static BusModel ToBusModel(this Entity.Bus bus)
        {
         
            return  Mapper.Map<BusModel>(bus);
        }
        public static Entity.Bus ToBus(this BusModel busModel)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Entity.Bus, BusModel>());
           
            return Mapper.Map<Entity.Bus>(busModel);
        }


    }
}

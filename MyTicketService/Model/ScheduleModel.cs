using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyTicketService.Model
{
    [DataContract]
    public class ScheduleModel
    {
        [DataMember]
        public int ScheduleID { get; set; }
        [DataMember]
        public string DepartureTime { get; set; }
     
        [DataMember]
        public string RouteName { get; set; }
        [DataMember]
        public string ScheduleTime { get; set; }


    }
}
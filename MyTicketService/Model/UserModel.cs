using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyTicketService.Model
{[DataContract]
    public class UserModel
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public UserType UserType { get; set; }



    }
}
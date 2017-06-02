using DataTranferObject.Validation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    [Validator(typeof(BusValidation))]
    public class BusModel
    {
        public int BusID { get; set; }
        public BusType BusType { get; set; }

        public int Capacity { get; set; }

        

    }
public enum BusType
{
    Economics,Business
}
}

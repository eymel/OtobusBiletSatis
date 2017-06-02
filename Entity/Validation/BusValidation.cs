
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BusValidation : AbstractValidator<Bus>
    {
        public BusValidation()
        {
           // RuleFor(x => x.BusType).NotEmpty().WithMessage("Bus Type is required");
            RuleFor(x => x.PlateNumber).NotEmpty().WithMessage("PlateNumber is required");

        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Validation
{
    public class RouteValidation:AbstractValidator<Route>
    {
        public RouteValidation()
        {
            RuleFor(x => x.DeparturePointID).NotEmpty().WithMessage("Departure City is required ");

            RuleFor(x => x.DestirationID).NotEmpty().WithMessage("Destiration City is required ");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price is required ");
        }
    }
}

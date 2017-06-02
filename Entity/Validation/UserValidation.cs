
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Zorunludur.").EmailAddress().WithMessage("GeçersizFormat");
            RuleFor(x => x.IdentityNumber).NotEmpty().Length(11, 11).WithMessage("11 Haneli Tc Kimlik No yu Giriniz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Zorunludur");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisim zorunludur");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola zorunludur");

        }
    }

}

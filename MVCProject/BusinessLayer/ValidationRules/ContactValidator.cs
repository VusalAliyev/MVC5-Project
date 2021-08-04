using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresinizi yazmalısınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Bu bölümü boş keçə bilməzsiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Bu bölümü boş keçə bilməzsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Ən az 3 hərf girməlisiniz");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Ən çox 50 hərf girməlisiniz");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Ən az 3 hərf girməlisiniz");
        }
    }
}

using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Bu bölümü boş keçə bilməzsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Bu bölümü boş keçə bilməzsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Bu bölümü boş keçə bilməzsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Ən az 3 hərf girməlisiniz");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Ən çox 100 hərf girməlisiniz");
        }
       
    }
}

using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş keçə bilmərsiniz...");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş keçə bilmərsiniz...");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Haqqımda boş keçə bilmərsiniz...");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı ən az 2 hərfli ola bilər...");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Yazar adı ən çox 20 hərfli ola bilər...");
        }
    }
}
    
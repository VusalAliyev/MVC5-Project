using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategoriya adını boş keçə bilmərsiniz...");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıqlamanı boş keçə bilmərsiniz...");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategoriya adı ən az 3 hərfli ola bilər...");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategoriya adı ən çox 20 hərfli ola bilər...");
        }
    }
}

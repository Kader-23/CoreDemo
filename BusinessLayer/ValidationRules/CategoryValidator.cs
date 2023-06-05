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
            RuleFor(X => X.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(X => X.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz");
            RuleFor(X => X.CategoryName).MaximumLength(50).WithMessage("Kategori adı en fazla 50 olmalıdır");
            RuleFor(X => X.CategoryName).MinimumLength(2).WithMessage("Kategori adı en az 2 olmalıdır");

        }
    }
}

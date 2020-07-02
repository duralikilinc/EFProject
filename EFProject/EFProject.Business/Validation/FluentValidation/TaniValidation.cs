using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EFProject.Entities.Concrete;

namespace EFProject.Business.Validation.FluentValidation
{
   public class TaniValidation :AbstractValidator<Tani>
    {
        public TaniValidation()
        {
            RuleFor(m => m.DosyaNo).NotEmpty();
            RuleFor(m => m.TaniAdi).NotEmpty();
        }
    }
}

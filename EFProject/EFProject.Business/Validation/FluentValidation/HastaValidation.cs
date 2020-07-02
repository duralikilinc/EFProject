using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EFProject.Entities.Concrete;

namespace EFProject.Business.Validation.FluentValidation
{
   public class HastaValidation:AbstractValidator<HastaKarti>
    {
        public HastaValidation()
        {
            RuleFor(m => m.Ad_Soyad).NotEmpty();
            RuleFor(m => m.TCNo).NotEmpty();
            RuleFor(m => m.DogumYili).NotEmpty();
            RuleFor(m => m.DogumYili).LessThan(DateTime.Now.Year);
            RuleFor(m => m.TCNo).Length(11);
        }
    }
}

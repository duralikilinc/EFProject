using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFramework.Core.Aspects.Postsharp.AuthorizationAspects;
using RepositoryFramework.Core.Aspects.Postsharp.ValidationAspects;
using EFProject.Business.Abstract;
using EFProject.Business.Validation.FluentValidation;
using EFProject.DataAccess.Abstract;
using EFProject.Entities.Concrete;

namespace EFProject.Business.Concrete.Manager
{
   public class TaniManager:ITaniService
   {
       private ITaniDal _taniDal;
        public TaniManager(ITaniDal taniDal)
        {
            _taniDal = taniDal;
        }

        [FluentValidationAspect(typeof(TaniValidation))]
        [SecuredOperation(Roles = "Doktor")]
        public void Add(Tani tani)
        {
            _taniDal.Add(tani);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EFProject.Business.Abstract;
using EFProject.DataAccess.Abstract;
using EFProject.Entities.Concrete;
using  RepositoryFramework.Core.Aspects.Postsharp.AuthorizationAspects;
using RepositoryFramework.Core.Aspects.Postsharp.ValidationAspects;
using EFProject.Business.Validation.FluentValidation;

namespace EFProject.Business.Concrete.Manager
{
    public class HastaManager:IHastaService
    {
        private IHastaKartiDal _hastaKartiDal;
        private IMapper _mapper;

        public HastaManager(IHastaKartiDal hastaKartiDal, IMapper mapper)
        {
            _hastaKartiDal = hastaKartiDal;
            _mapper = mapper;
        }
        [SecuredOperation(Roles = "Sekreter")]
        public List<HastaKarti> GetAll()
        {
           return _hastaKartiDal.GetList();
        }

        [FluentValidationAspect(typeof(HastaValidation))]
        [SecuredOperation(Roles = "Sekreter")]
        public void Add(HastaKarti hastaKarti)
        {
            _hastaKartiDal.Add(hastaKarti);
        }
        [SecuredOperation(Roles = "Sekreter")]
        public List<HastaKarti> GetAllWebApi(string tc)
        {
            var hasta = _mapper.Map<List<HastaKarti>>(_hastaKartiDal.GetList(k=>k.TCNo==tc));
            return hasta;
        }
    }
}

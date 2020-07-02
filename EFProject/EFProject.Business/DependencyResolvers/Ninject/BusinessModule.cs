using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using RepositoryFramework.Core.DataAccess;
using RepositoryFramework.Core.DataAccess.EntityFramework;
using EFProject.Business.Abstract;
using EFProject.Business.Concrete.Manager;
using EFProject.DataAccess.Abstract;
using EFProject.DataAccess.Concrete.EntityFramework;
using EFProject.DataAccess.Concrete;
using EFProject.DataAccess.Concrete.EntityFramework;

namespace EFProject.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IHastaService>().To<HastaManager>().InSingletonScope();
            Bind<IHastaKartiDal>().To<EfHastaDal>().InSingletonScope();

            Bind<ITaniService>().To<TaniManager>().InSingletonScope();
            Bind<ITaniDal>().To<EfTaniDal>().InSingletonScope();

            Bind<IKullaniciService>().To<KullaniciManager>().InSingletonScope();
            Bind<IKullaniciDal>().To<EfKullaniciDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<HastaneContext>();
          
        }
    }
}

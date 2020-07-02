using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFProject.DataAccess.Abstract;
using EFProject.Entities.Concrete;
using RepositoryFramework.Core.DataAccess.EntityFramework;


namespace EFProject.DataAccess.Concrete.EntityFramework
{
   public class EfHastaDal : EfEntityRepositoryBase<HastaKarti, HastaneContext>, IHastaKartiDal
    {

    }
}

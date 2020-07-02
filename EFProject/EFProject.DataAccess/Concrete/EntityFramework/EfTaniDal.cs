using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFramework.Core.DataAccess.EntityFramework;
using EFProject.DataAccess.Abstract;
using EFProject.DataAccess.Concrete.EntityFramework;
using EFProject.Entities.Concrete;

namespace EFProject.DataAccess.Concrete.EntityFramework
{
    public class EfTaniDal : EfEntityRepositoryBase<Tani, HastaneContext>, ITaniDal
    {
    }
}

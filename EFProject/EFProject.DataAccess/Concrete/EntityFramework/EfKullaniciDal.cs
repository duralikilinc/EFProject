using System.Collections.Generic;
using System.Linq;
using EFProject.DataAccess.Abstract;
using RepositoryFramework.Core.DataAccess.EntityFramework;
using EFProject.Entities.ComplexType;
using EFProject.Entities.Concrete;

namespace EFProject.DataAccess.Concrete.EntityFramework
{
    public class EfKullaniciDal : EfEntityRepositoryBase<Kullanici, HastaneContext>, IKullaniciDal
    {
        public List<KullaniciRoleItem> GetUserRoles(Kullanici user)
        {
            using (HastaneContext context=new HastaneContext())
            {
                var result = from kr in context.KullaniciRole
                    join r in context.Role
                        on kr.RoleId equals r.Id
                    where kr.KullaniciId == user.Id
                    select new KullaniciRoleItem {RoleName = r.RoleAd};

                return result.ToList();
            }
        }
    }
}

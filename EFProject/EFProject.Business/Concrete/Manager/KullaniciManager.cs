using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFProject.Business.Abstract;
using EFProject.DataAccess.Abstract;
using EFProject.Entities.ComplexType;
using EFProject.Entities.Concrete;

namespace EFProject.Business.Concrete.Manager
{
   public class KullaniciManager:IKullaniciService
   {
       private IKullaniciDal _kullaniciDal;

       public KullaniciManager(IKullaniciDal kullaniciDal)
       {
           _kullaniciDal = kullaniciDal;
       }

       public Kullanici GetByUserNameAndPassword(string userName, string password)
       {
           return _kullaniciDal.Get(k => k.UserName == userName && k.Password == password);
       }

        public List<KullaniciRoleItem> GetUserRoles(Kullanici user)
        {
            return _kullaniciDal.GetUserRoles(user);
        }
    }
}

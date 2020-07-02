using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFProject.Entities.ComplexType;
using EFProject.Entities.Concrete;

namespace EFProject.Business.Abstract
{
   public interface IKullaniciService
    {
        Kullanici GetByUserNameAndPassword(string userName, string password);
        List<KullaniciRoleItem> GetUserRoles(Kullanici user);
    }
  
}

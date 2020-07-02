using EFProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryFramework.Core.CrossCuttingConcerns.Security.Web;

namespace EFProject.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IKullaniciService _kullaniciService;

        public AccountController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }

        public string Login()
        {
            var user = _kullaniciService.GetByUserNameAndPassword("doktor", "123456");
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(),
                    user.UserName,
                    DateTime.Now.AddMinutes(1),
                    _kullaniciService.GetUserRoles(user).Select(k=>k.RoleName).ToArray(),
                    false,
                    user.FirstName,
                    user.LastName
                    );

                

                return "User is authenticated";
            }

            return "User is Not authenticated";
        }
    }
}
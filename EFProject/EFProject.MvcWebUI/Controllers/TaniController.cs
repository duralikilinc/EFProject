using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFProject.Business.Abstract;
using EFProject.Entities.Concrete;
using EFProject.MvcWebUI.Filters;
using EFProject.MvcWebUI.Models;
using RepositoryFramework.Core.Aspects.Postsharp.AuthorizationAspects;

namespace EFProject.MvcWebUI.Controllers
{
    
    public class TaniController : Controller
    {
        private ITaniService _taniService;

        public TaniController(ITaniService taniService)
        {
            _taniService = taniService;
        }

        // GET: Tani
       public ActionResult Index()
        {
            return View(new TaniAddViewModel());
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Index(Tani tani)
        {
            _taniService.Add(tani);
            return View(new TaniAddViewModel());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFProject.Business.Abstract;
using EFProject.Entities.Concrete;
using EFProject.MvcWebUI.Filters;
using EFProject.MvcWebUI.Models;

namespace EFProject.MvcWebUI.Controllers
{
    [ExceptionHandler]
    public class HastaController : Controller
    {
        private IHastaService _hastaService;

        public HastaController(IHastaService hastaService)
        {
            _hastaService = hastaService;
        }

        public ActionResult Index()
        {

            var model = new HastaListViewModel
            {
                HastaKarti = _hastaService.GetAll()
            };
            return View(model);


        }

        // GET: Hasta
        public ActionResult Add()
        {
            return View(new HastaAddViewModel());
        }

        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(HastaKarti hasta)
        {
            _hastaService.Add(hasta);
            return View("Index");
        }

        public ActionResult Search()
        {
            return View(new HastaViewModel());
        }
        
    }
}
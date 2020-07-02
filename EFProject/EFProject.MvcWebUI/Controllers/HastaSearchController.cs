using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using EFProject.Business.Abstract;
using EFProject.Entities.Concrete;
using EFProject.MvcWebUI.Filters;

namespace EFProject.MvcWebUI.Controllers
{
   
    public class HastaSearchController : ApiController
    {
        private IHastaService _hastaService;

        public HastaSearchController(IHastaService hastaService)
        {
            _hastaService = hastaService;
        }
        [ExceptionHandler]
        public List<HastaKarti> Get(string tc)
        {
            var result = _hastaService.GetAllWebApi(tc);

            return result;
        }

    }
}

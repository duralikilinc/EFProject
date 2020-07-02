using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFProject.MvcWebUI.Filters
{
    public class ExceptionHandlerAttribute: FilterAttribute, IExceptionFilter
    {
        
        public void OnException(ExceptionContext filterContext)
        {

            var message = filterContext.Exception.Message;
            filterContext.Controller.ViewData.ModelState.AddModelError("FilterException", message);
            filterContext.ExceptionHandled = true;
           
            filterContext.Result = new ViewResult
            {
                ViewData = new ViewDataDictionary(filterContext.Controller.ViewData),
                ViewName ="~/Views/Error/Index.cshtml"
            };
            
        }
    }
}
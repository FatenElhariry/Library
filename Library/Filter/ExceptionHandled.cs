using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Filter
{
    public class ExceptionHandler : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            string Path = filterContext.HttpContext.Server.MapPath("~/Logs/LogFile.txt");

            File.AppendAllText(Path, filterContext.Exception.Message);
            filterContext.ExceptionHandled = true;

            filterContext.HttpContext.Response.Redirect("~/Error");
        }
    }
}
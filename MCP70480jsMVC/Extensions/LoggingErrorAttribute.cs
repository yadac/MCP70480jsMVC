using MCP70480jsMVC.Models;
using System;
using System.Web.Mvc;

namespace MCP70480jsMVC.Extensions
{
    public class LoggingErrorAttribute : FilterAttribute, IExceptionFilter
    {
        private BasicContext db = new BasicContext();

        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            var route = filterContext.RouteData;
            var exp = filterContext.Exception;
            var err = new ErrorLog()
            {
                Controller = route.Values["controller"].ToString(),
                Action = route.Values["action"].ToString(),
                Message = exp.Message,
                Stacktrace = exp.StackTrace,
                Updated = DateTime.Now,
            };

            db.ErrorLogs.Add(err);
            db.SaveChanges();
        }
    }
}
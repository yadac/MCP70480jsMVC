using System;
using System.Web.Mvc;

namespace MCP70480jsMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // global filter
            filters.Add(new HandleErrorAttribute());

            filters.Add(new HandleErrorAttribute()
            {
                Order = 2,
                ExceptionType = typeof(ArgumentException),
                View = "ErrorSpare"
            });
        }
    }
}

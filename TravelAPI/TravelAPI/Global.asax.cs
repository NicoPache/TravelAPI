using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TravelAPI.App_Start;

namespace TravelAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var cors = new EnableCorsAttribute("*", "*", "*"); // Asegúrate de reemplazar esto con el origen de tu frontend
            GlobalConfiguration.Configuration.EnableCors(cors);

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
           
            UnityConfig.RegisterComponents();
        }
    }
}

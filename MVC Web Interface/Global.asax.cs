using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Integration.Mvc;

namespace MVC_Web_Interface
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var container = DependencyInjectionConfig.Configure();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            AutoMapperConfig.Configure();
        }
    }
}

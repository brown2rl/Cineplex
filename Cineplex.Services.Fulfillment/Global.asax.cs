using System;
using System.Web.Http;

namespace Cineplex.Services.Fulfillment
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
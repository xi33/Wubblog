﻿// User: phil | Date: 15/02/2012 | Time: 14:40
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Wubblog.Web
{
	public class MvcApplication : HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.Ignore("{resource}.axd/{*pathInfo}");
			
			routes.MapRoute(
				"Default",
				"{controller}/{action}/{id}",
				new {
					controller = "Home",
					action = "Index",
					id = UrlParameter.Optional
				});
		}
		
		protected void Application_Start()
		{
			RegisterRoutes(RouteTable.Routes);
		}
	}
}

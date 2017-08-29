using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ex1
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			//the best part abour reouting is the search engine optimzation.
	
			//block and ignore requests that end with .axd
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			//bloack and ignore requests that end with .config
			routes.IgnoreRoute("{resource}.config/{*pathInfo}");


			//Names for each route has to be unique, can't be the same

			routes.MapRoute(
				name: "Home",
				url: "Home",
				defaults: new { controller = "Home", action = "Ali", id = UrlParameter.Optional }
			);

			routes.MapRoute(
				name: "Home1",
				url: "Home/Home",
				defaults: new { controller = "Home", action = "Ali", id = UrlParameter.Optional }
			);


			// to make a certain view at the start page, you need to leave a blank for the url, like below
			// and also you have to change the controller and the action

			//the reson for this is because, there is no start page in MVC, the route will not allow you.
			routes.MapRoute(
				name: "Home2",
				url: "",
				defaults: new { controller = "Home", action = "Ali", id = UrlParameter.Optional }
			);

			routes.MapRoute(
				name: "Home.",
				url: ".",
				defaults: new { controller = "Home", action = "Ali", id = UrlParameter.Optional }
			);


			//this one should be last, or routes will be byipassed
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}

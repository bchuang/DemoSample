using Autofac;
using Autofac.Integration.WebApi;
using DemoSample.BusinessLib.UserPermissionService.BLL;
using DemoSample.BusinessLib.UserPermissionService.Factories;
using DemoSample.WEBAPI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DemoSample.WEBAPI
{
		public static class WebApiConfig
		{
				public static void Register(HttpConfiguration config)
				{
						// Web API 設定和服務

						//RequestFilter
						config.Filters.Add(new LogRequestFilter());

						// 跨站Access
						//var cors = new EnableCorsAttribute("*", "*", "*");
						//config.EnableCors(cors);

						// Web API 路由
						config.MapHttpAttributeRoutes();

						//config.Routes.MapHttpRoute(
						//    name: "DefaultApi",
						//    routeTemplate: "api/{controller}/{action}"
						//);

						//AutoFac
						AutoFac(config);
				}

				public static void AutoFac(HttpConfiguration config)
				{
						var builder = new ContainerBuilder();

						#region Register

						builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
						builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces().AsSelf();
						builder.RegisterInstance<IUserManager>(UserPermissionServiceFactory.GetUserManager(true));

						#endregion Register

						var container = builder.Build();
						config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
				}
		}
}
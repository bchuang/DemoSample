using Autofac;
using Autofac.Integration.WebApi;
using DemoSample.BusinessLib.UserPermissionService.BLL;
using DemoSample.BusinessLib.UserPermissionService.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace DemoSample.WEBAPI
{
		public class WebApiApplication : System.Web.HttpApplication
		{
				protected void Application_Start()
				{
						GlobalConfiguration.Configure(WebApiConfig.Register);

#if DEBUG
						//開啟詳細錯誤資訊
						GlobalConfiguration.Configuration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
#endif
				}
		}
}
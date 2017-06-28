using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoSample.WebSite.Common
{
    internal sealed class AuthorizationFilter : IAuthorizationFilter
    {
        public AuthorizationFilter()
        {
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var broswerInfo = filterContext.RequestContext.HttpContext.Request.UserAgent.ToLower();
            //TODO if axios,fetch will running without (X-Requested-With: XMLHttpRequest)
            var isAjaxRequest = filterContext.HttpContext.Request.IsAjaxRequest();

            var controller = filterContext.Controller;
            if (controller is Controller && !isAjaxRequest)
            {
                var actionDescriptor = filterContext.ActionDescriptor;
                var controllerDescriptor = filterContext.ActionDescriptor.ControllerDescriptor;
                var hasAuthorized = this.Authorize(controllerDescriptor.ControllerName, actionDescriptor.ActionName);
                if (!hasAuthorized)
                {
                    filterContext.Result = new RedirectResult(string.Format("~/Home/Unauthorized?oriUrl={0}/{1}", controllerDescriptor.ControllerName, actionDescriptor.ActionName));
                    return;
                }
            }
        }

        private bool Authorize(string controllerName, string actionName)
        {
            //TODO
            return true;
        }
    }
}
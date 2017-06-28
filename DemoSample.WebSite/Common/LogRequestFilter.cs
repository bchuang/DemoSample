using System.Web.Mvc;

namespace DemoSample.WebSite.Common
{
    internal class LogRequestFilter : ActionFilterAttribute
    {
        public LogRequestFilter()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var actionDescriptor = filterContext.ActionDescriptor;
            var formData = filterContext.ActionParameters;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var actionDescriptor = filterContext.ActionDescriptor;
        }

        private void WrtieLog()
        {
            //TODO RequestLog
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace DemoSample.WEBAPI.Filters
{
    public class LogRequestFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //TODO  Validation  Request (like model validation, token validation...etc)
            CheckRequest();
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
        }

        private bool CheckRequest()
        {
            //TODO  Validation  Request
            throw new NotImplementedException();
        }
    }
}
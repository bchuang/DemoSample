using DemoSample.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoSample.WEBAPI.Controllers
{
    public class ApiControllerBase : ApiController
    {
        protected HttpResponseMessage TryCatch(Func<ServiceResult> func)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.Accepted,
                    ResultConvertHelper.ServiceResultToApiResult(func()));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.Accepted,
                    new ApiResult() { IsOk = false, Message = "Service Exception" });
            }
        }

        protected HttpResponseMessage TryCatch<T>(Func<ServiceResult<T>> func)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.Accepted,
                    ResultConvertHelper.ServiceResultToApiResult(func()));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.Accepted,
                    new ApiResult() { IsOk = false, Message = "Service Exception" });
            }
        }
    }
}
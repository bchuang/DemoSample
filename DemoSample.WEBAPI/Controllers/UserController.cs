using DemoSample.BusinessLib.UserPermissionService.BLL;
using DemoSample.BusinessLib.UserPermissionService.Factories;
using DemoSample.Models.Base;
using DemoSample.Models.UserPermission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoSample.WEBAPI.Controllers
{
    /// <summary> 使用者管理 </summary>
    [RoutePrefix("api/User")]
    [Route("{acct?}")]
    [CamelCasedController]
    public class UserController : ApiControllerBase
    {
        private readonly IUserManager userManager = UserPermissionServiceFactory.GetUserManager(true);

        /// <summary> 取得使用者清單 </summary>
        /// <returns></returns>
        public HttpResponseMessage Get()
        {
            return TryCatch(() => userManager.Get());
        }

        /// <summary> 取得使用者資訊 </summary>
        /// <param name="acct"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public HttpResponseMessage Get(string acct)
        {
            return TryCatch(() => userManager.Get(acct));
        }

        /// <summary> 新增使用者 </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public HttpResponseMessage Post([FromBody]User user)
        {
            return TryCatch(() => userManager.Add(user));
        }

        /// <summary> 刪除使用者 </summary>
        /// <param name="acct"></param>
        /// <returns></returns>
        public HttpResponseMessage Delete(string acct)
        {
            return TryCatch(() => userManager.Delete(acct));
        }

        /// <summary> 更新使用者 </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public HttpResponseMessage Put([FromBody]User user)
        {
            return TryCatch(() => userManager.Update(user));
        }
    }
}
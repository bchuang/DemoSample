using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoSample.WebSite.Controllers
{
    /// <summary> 使用者管理 </summary>
    public class UserController : Controller
    {
        /// <summary> 首頁 </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary> 註冊 </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }

        /// <summary> 更新 </summary>
        /// <returns></returns>
        public ActionResult Update()
        {
            return View();
        }
    }
}
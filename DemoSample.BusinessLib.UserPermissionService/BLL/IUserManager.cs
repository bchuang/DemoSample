using DemoSample.Models.Base;
using DemoSample.Models.UserPermission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSample.BusinessLib.UserPermissionService.BLL
{
    /// <summary> 使用者管理 </summary>
    public interface IUserManager
    {
        /// <summary> 取得使用者清單 </summary>
        /// <returns></returns>
        ServiceResult<List<User>> Get();

        /// <summary> 取得使用者資訊 </summary>
        /// <param name="acct"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        ServiceResult<User> Get(string acct);

        /// <summary> 新增使用者 </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        ServiceResult<User> Add(User user);

        /// <summary> 更新使用者 </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        ServiceResult Update(User user);

        /// <summary> 刪除 </summary>
        /// <param name="acct"></param>
        /// <returns></returns>
        ServiceResult Delete(string acct);
    }
}
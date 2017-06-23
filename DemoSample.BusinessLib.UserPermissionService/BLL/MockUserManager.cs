using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSample.Models.UserPermission;
using DemoSample.Framework.TestDataGenerator;
using DemoSample.Models.Base;

namespace DemoSample.BusinessLib.UserPermissionService.BLL
{
    internal class MockUserManager : IUserManager
    {
        private static List<UserModel> userList;

        public MockUserManager()
        {
            if (userList == null)
            {
                InitialUserList();
            }
        }

        private void InitialUserList()
        {
            userList = new List<UserModel>();

            userList.AddRange(new GeneratorHelper().MakeClassData(new List<UserModel>()));
        }

        public ServiceResult<List<UserModel>> Get()
        {
            return ServiceResult<List<UserModel>>.Ok(userList);
        }

        public ServiceResult<UserModel> Get(string acct)
        {
            var data = userList.Where(o => o.Acct == acct).FirstOrDefault();
            return ServiceResult<UserModel>.Ok(data);
        }

        public ServiceResult<UserModel> Add(UserModel user)
        {
            if (CheckAcctExists(user.Acct))
            {
                return ServiceResult<UserModel>.Error("帳號已存在，請重新註冊。");
            }
            else
            {
                user.Id = Guid.NewGuid();
                userList.Add(user);
                return ServiceResult<UserModel>.Ok(user);
            }
        }

        public ServiceResult Update(UserModel user)
        {
            if (CheckAcctExists(user.Acct))
            {
                var data = userList.Where(o => o.Acct == user.Acct);
                foreach (var item in data)
                {
                    item.Name = user.Name;
                }

                return ServiceResult.Ok();
            }
            else
            {
                return ServiceResult.Error("帳號不存在，無法更新。");
            }
        }

        public ServiceResult Delete(string acct)
        {
            if (CheckAcctExists(acct))
            {
                userList.RemoveAll(o => o.Acct == acct);
                return ServiceResult.Ok();
            }
            else
            {
                return ServiceResult.Error("帳號不存在，無法刪除。");
            }
        }

        private bool CheckAcctExists(string acct)
        {
            return userList.Exists(o => o.Acct == acct);
        }
    }
}
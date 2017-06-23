using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSample.Models.Base;
using DemoSample.Models.UserPermission;

namespace DemoSample.BusinessLib.UserPermissionService.BLL
{
    internal class UserManager : IUserManager
    {
        public ServiceResult<UserModel> Add(UserModel user)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Delete(string acct)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<List<UserModel>> Get()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<UserModel> Get(string acct)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Update(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
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
        public ServiceResult<User> Add(User user)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Delete(string acct)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<List<User>> Get()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<User> Get(string acct)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
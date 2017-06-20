using DemoSample.BusinessLib.UserPermissionService.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSample.BusinessLib.UserPermissionService.Factories
{
    public static class UserPermissionServiceFactory
    {
        public static IUserManager GetUserManager(bool isMock = false)
        {
            if (isMock)
            {
                return new MockUserManager();
            }
            else
            {
                return new UserManager();
            }
        }
    }
}
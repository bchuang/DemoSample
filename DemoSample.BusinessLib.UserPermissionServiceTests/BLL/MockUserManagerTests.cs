using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoSample.BusinessLib.UserPermissionService.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSample.BusinessLib.UserPermissionService.Factories;
using DemoSample.Models.UserPermission;

namespace DemoSample.BusinessLib.UserPermissionService.BLL.Tests
{
    [TestClass()]
    public class MockUserManagerTests
    {
        private readonly IUserManager usermanager = UserPermissionServiceFactory.GetUserManager(true);

        [TestMethod()]
        public void GetTest()
        {
            var data = usermanager.Get();
            Assert.AreEqual(true, data.IsOk);
        }

        [TestMethod()]
        public void GetTestAcct()
        {
            var testAcct = Guid.NewGuid().ToString();
            var data = usermanager.Get(testAcct);
            Assert.AreEqual(null, data.Data);
        }

        [TestMethod()]
        public void AddTest()
        {
            //Insert data
            var addData = new User { Acct = "Test001" };
            usermanager.Add(addData);
            //Get insert data, check exist
            var addedData = usermanager.Get("Test001");
            Assert.AreEqual(true, addedData.Data != null);

            //Insert Again, check insert again denie.
            var inputDataAgain = usermanager.Add(addData);
            Assert.AreEqual(false, inputDataAgain.IsOk);
            Assert.AreEqual("帳號已存在，請重新註冊。", inputDataAgain.Message);

            //Remove check data
            usermanager.Delete("Test001");
        }

        [TestMethod()]
        public void UpdateTest()
        {
            //Get FirstData, check exist
            var updateData = usermanager.Get().Data.FirstOrDefault();
            Assert.AreEqual(true, updateData != null);

            //Update name
            var changeName = $"{updateData.Name}_BookMan";
            updateData.Name = changeName;
            usermanager.Update(updateData);

            //Check UpdatedData, name changed
            var updatedData = usermanager.Get(updateData.Acct);
            Assert.AreEqual(changeName, updatedData.Data.Name);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            //Insert
            var addData = new User { Acct = "Test001" };
            usermanager.Add(addData);
            //Get data , check exist
            var addedData = usermanager.Get("Test001");
            Assert.AreEqual(true, addedData.Data != null);

            //Remove data
            usermanager.Delete("Test001");

            //Check remove data not exist
            var deletedData = usermanager.Get("Test001");
            Assert.AreEqual(true, deletedData.Data == null);
        }
    }
}
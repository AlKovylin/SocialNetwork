using NUnit.Framework;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Tests.BLL.Tests.Service.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void EmailValidShouldThrowAnArgumentNullException()
        {
            var userService = new UserService();

            Assert.Throws<ArgumentNullException>(() => userService.EmailValid("address"));
        }

        [Test]
        public void EmailValidShouldNotThrowAnArgumentNullException()
        {
            var userService = new UserService();

            Assert.DoesNotThrow(() => userService.EmailValid("ivanov@mail.ru"));
        }
    }
}

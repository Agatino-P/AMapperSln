using System;
using AMapperCore.Users.Models;
using NUnit;
using NUnit.Framework;

namespace Users.Test
{
    [TestFixture]
    public class UserTest

    {
        [Test]
        public void CreateNewUser()
        {
            //Arrange
            const string FIRST = "First";
            const string LAST = "Last";
            //Act
            User user = new User.Builder().WithFirstName(FIRST).WithLastName(LAST).Build();
            //Assert
            Assert.AreNotEqual(user.Guid, Guid.Empty);
            Assert.AreEqual(user.FirstName, FIRST);
            Assert.AreEqual(user.LastName, LAST);
        }
    }
}

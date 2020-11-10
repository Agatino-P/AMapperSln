using System;
using AMapperCore.Users.Models;
using NUnit;
using NUnit.Framework;

namespace Users.Test
{
    [TestFixture]
    public class UserDTOTest

    {
        [Test]
        public void CreateNewUserDTO()
        {
            //Arrange
            const string FIRST = "First";
            const string LAST = "Last";
            //Act
            User user = new User.Builder().WithFirstName(FIRST).WithLastName(LAST).Build();
            UserDTO userDTO = new UserDTO.Builder().WithUser(user).Build();
            //Assert
            Assert.AreEqual(user.Guid, userDTO.Guid);
            Assert.AreEqual(user.FirstName, userDTO.FirstName);
            Assert.AreEqual(user.LastName, userDTO.LastName);
        }
    }
}

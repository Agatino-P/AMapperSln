using AMapperCore.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AMapperCore.Users.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>();

        public bool HasUser(string firstName, string lastName)
        {
            return _users.Any(u => u.FirstName == firstName && u.LastName == lastName);
        }


        public Guid AddUser(string firstName, string lastName)
        {
            if (HasUser(firstName, lastName))
            {
                return Guid.Empty;
            }

            return new User.Builder().WithFirstName(firstName).WithLastName(lastName).Build().Guid;

        }

        public Guid AddUser(UserDTO userDTO)
        {
            UserDTOValidator userDTOValidator = new UserDTOValidator();
            if (userDTOValidator.Validate(userDTO).IsValid)
            {
                return AddUser(userDTO.FirstName, userDTO.LastName);
            }
            else
            {
                return Guid.Empty;
            }
        }

        public IEnumerable<Guid> GetGuids()
        {
            return _users.Select(u => u.Guid);
        }

        public UserDTO GetUserDTO(Guid guid)
        {
            User retUser = _users.FirstOrDefault(u => u.Guid == guid);
            return retUser == null ? null : new UserDTO.Builder().WithUser(retUser).Build();
        }
        public UserDTO GetUserDTO(string firstName, string lastName)
        {
            User retUser = _users.FirstOrDefault(u => u.FirstName == firstName && u.LastName == lastName);
            if (retUser != null)
            {
                return GetUserDTO(retUser.Guid);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<UserDTO> GetUserDTOs()
        {
            return GetGuids().Select(g => GetUserDTO(g));
        }

    }
}

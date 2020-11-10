using AMapperCore.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMapperCore.Users.Services
{
    public interface IUserService
    {
        bool HasUser(string firstName, string lastName);
        Guid AddUser(string firstName, string lastName);
        Guid AddUser(UserDTO userDTO);
        UserDTO GetUserDTO(Guid guid);
        UserDTO GetUserDTO(string firstName, string lastName);
        IEnumerable<Guid> GetGuids();
        IEnumerable<UserDTO> GetUserDTOs();

    }
}

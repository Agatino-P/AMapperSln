using FluentValidation;
using System;

namespace AMapperCore.Users.Models
{
    public partial class UserDTO
    {
        public class Builder
        {
            private UserDTO _userDTO;
            
            public Builder()
            {
                _userDTO = new UserDTO();
            }
            public Builder WithGuid(Guid guid)
            {
                _userDTO.Guid= guid;
                return this;
            }

            public Builder WithFirstName(string firstName)
            {
                _userDTO.FirstName = firstName;
                return this;
            }
            public Builder WithLastName(string lastName)
            {
                 _userDTO.LastName= lastName;
                return this;
            }

            public Builder WithUser(User user)
            {
                if (user != null)
                    return WithGuid(user.Guid).WithFirstName(user.FirstName).WithLastName(user.LastName);
                else
                    return this;
            }

            public UserDTO Build()
            {
                if (new Validator().Validate(_userDTO).IsValid)
                {
                    return _userDTO;
                }
                else
                {
                    return null;
                }
            }

        }
    }
}

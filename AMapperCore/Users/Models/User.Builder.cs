using FluentValidation;
using System;

namespace AMapperCore.Users.Models
{
    public partial class User
    {
        public class Builder
        {
            private User _user;

            public Builder()
            {
                _user = new User()
                { 
                    Guid = Guid.NewGuid() 
                };
            }
            public Builder WithGuid(Guid guid)
            {
                _user.Guid = guid;
                return this;
            }

            public Builder WithFirstName(string firstName)
            {
                _user.FirstName = firstName;
                
                return this;
            }
            public Builder WithLastName(string lastName)
            {
                _user.LastName = lastName;
                return this;
            }
            public Builder WithUserDTO(UserDTO userDTO)
            {
                if (userDTO != null)
                {
                    return WithFirstName(userDTO.FirstName).WithLastName(userDTO.LastName).WithGuid(userDTO.Guid);
                }
                else
                {
                    return this;
                }
            }
            public User Build()
            {
                if (new User.Validator().Validate(_user).IsValid)
                {
                    return _user;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

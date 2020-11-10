using System;

namespace AMapperCore.Users.Models
{
    public class UserDTO
    {
        public Guid Guid { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
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
                    return WithGuid(user.Guid).WithFirstName(user.FirstName).WithFirstName(user.LastName);
                else
                    return this;
            }

            public UserDTO Build()
            {
                if (new UserDTOValidator().Validate(_userDTO).IsValid)
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

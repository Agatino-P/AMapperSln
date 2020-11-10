using System;

namespace AMapperCore.Users.Models
{
    public class User
    {
        public Guid Guid { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Amount { get; set; }

        private User()
        {
            Guid = Guid.NewGuid();
        }

        public class Builder
        {
            private User _user;

            public Builder()
            {
                _user = new User();
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
                if (new UserValidator().Validate(_user).IsValid)
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

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMapperCore.Users.Models
{
    public class UserDTOValidator :AbstractValidator<UserDTO>
    {
        public UserDTOValidator()
        {
            RuleFor(userDTO => userDTO.Guid).NotEqual(Guid.Empty);
            RuleFor(userDTO => userDTO.FirstName).NotEmpty();
            RuleFor(userDTO => userDTO.LastName).NotEmpty();
        }
    }
}

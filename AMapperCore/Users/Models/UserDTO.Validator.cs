using FluentValidation;
using System;

namespace AMapperCore.Users.Models
{
    public partial class UserDTO
    {
        public class Validator : AbstractValidator<UserDTO>
        {
            public Validator()
            {
                RuleFor(userDTO => userDTO.Guid).NotEqual(Guid.Empty);
                RuleFor(userDTO => userDTO.FirstName).NotEmpty();
                RuleFor(userDTO => userDTO.LastName).NotEmpty();
            }
        }
    }
}

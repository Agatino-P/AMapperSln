using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMapperCore.Users.Models
{
    public class UserValidator :AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Guid).NotEqual(Guid.Empty);
            RuleFor(user => user.FirstName).NotEmpty();
            RuleFor(user => user.LastName).NotEmpty();
        }
    }
}

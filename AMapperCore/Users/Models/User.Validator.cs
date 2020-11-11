using FluentValidation;
using System;

namespace AMapperCore.Users.Models
{
    public partial class User
    {
        public class Validator : AbstractValidator<User>
        {
            public Validator()
            {
                RuleFor(user => user.Guid).NotEqual(Guid.Empty);
                RuleFor(user => user.FirstName).NotEmpty();
                RuleFor(user => user.LastName).NotEmpty();
            }
        }
    }
}

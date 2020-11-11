using System;

namespace AMapperCore.Users.Models
{
    public partial class User
    {
        public Guid Guid { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Amount { get; set; }

        private User()
        {
        }
    }
}

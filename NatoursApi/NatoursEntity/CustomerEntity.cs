using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursEntities
{
    public class CustomerEntity
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public int RoleId { get; set; }

        public RoleEntity role { get; set; }

        public int AddressId { get; set; }

        public AddressEntity address { get; set; }

    }
}

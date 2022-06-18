using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursEntities
{    
    public class CustomerEntity
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerUserName { get; set; }


        public string Password { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public int RoleId { get; set; }

        public RoleEntity role { get; set; }

        public int AddressId { get; set; }

        public AddressEntity address { get; set; }

        public string JwtToken { get; set; }

    }
}

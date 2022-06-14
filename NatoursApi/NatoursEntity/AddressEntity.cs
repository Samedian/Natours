using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursEntities
{
    public class AddressEntity
    {
        public int AddressId { get; set; }

        public string AddressLine { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

    }
}

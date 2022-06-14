using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursEntities
{
    public class BookingEntity
    {
        public int BookingId { get; set; }

        public int CustomerId { get; set; }

        public CustomerEntity customer { get; set; }

        public int PackageId { get; set; }

        public PackageEntity package { get; set; }

        public int NumberOfPeople { get; set; }

    }
}

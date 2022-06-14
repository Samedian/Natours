using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NatoursRepositoryLayer.Model
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int AddressId { get; set; }

        [MaxLength(50)]
        public string AddressLine { get; set; }

        [MaxLength(25)]
        public string City { get; set; }

        [MaxLength(25)]
        public string State { get; set; }

        [MaxLength(25)]
        public string Country { get; set; }
    }
}

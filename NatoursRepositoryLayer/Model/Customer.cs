using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NatoursRepositoryLayer.Model
{
    [Index(nameof(CustomerName), IsUnique = true)]

    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int CustomerId { get; set; }

        [MaxLength(50)]
        [Required]
        public string CustomerName { get; set; }

        [MaxLength(50)]
        [Required]
        public string CustomerUserName { get; set; }


        [MaxLength(50)]
        [Required]
        [NotMapped]
        public string Password { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role role { get; set; }

        [Required]
        public int AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address address { get; set; }

        [NotMapped]
        public string JwtToken { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NatoursRepositoryLayer.Model
{
    [Index(nameof(RoleName), IsUnique = true)]
    public class Role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int RoleId { get; set; }

        [Column("RoleName", TypeName = "nvarchar")]
        [MaxLength(20)]
        [Required]
        public string RoleName { get; set; }
    }
}

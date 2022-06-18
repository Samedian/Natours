using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NatoursRepositoryLayer.Model
{
    [Index(nameof(StatusName), IsUnique = true)]

    public class Status
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int StatusId { get; set; }

        [MaxLength(50)]
        [Required]
        public string StatusName { get; set; }
    }
}

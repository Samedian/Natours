using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NatoursRepositoryLayer.Model
{
    [Index(nameof(PackageName), IsUnique = true)]

    public class Package
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int PackageId { get; set; }

        [MaxLength(50)]
        [Required]
        public string PackageName { get; set; }

        [Required]
        public int NumberOfDays { get; set; }

        [Required]
        public int NumberOfGuides { get; set; }

        [Required]
        public int MaxNumberOfPeople { get; set; }

        [MaxLength(50)]
        [Required]
        public string ModeOfSleep { get; set; }

        [Required]
        public int DifficultyId { get; set; }

        [ForeignKey("DifficultyId")]
        public Difficulty difficulty { get; set; }

        //[DefaultValue(0)]
        [NotMapped]
        public int PeopleBooked { get; set; }

        [DefaultValue(0)]
        public double Cost { get; set; }
    }
}

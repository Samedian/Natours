using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursEntities
{
    public class PackageEntity
    {
        public int PackageId { get; set; }

        public string PackageName { get; set; }

        public int NumberOfDays { get; set; }

        public int NumberOfGuides { get; set; }

        public int MaxNumberOfPeople { get; set; }

        public string ModeOfSleep { get; set; }

        public int DifficultyId { get; set; }

        public DifficultyEntity difficultyEntity { get; set; }
        public int PeopleBooked { get; set; }
        public double Cost { get; set; }


    }
}

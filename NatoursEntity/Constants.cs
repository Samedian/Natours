using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursEntities
{
    public class Constants
    {
        public enum RolesConstant
        {
            Admin,
            User
        }

        public enum DifficultyConstant
        {
            Easy,
            Medium,
            Hard
        }

        public enum StatusConstant
        {
            InProgress,
            Approved,
            Rejected,
            Cancelled,
            Completed
        }
    }
}

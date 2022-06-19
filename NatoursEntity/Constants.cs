using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursEntities
{
    public class Constants
    {
        public enum RolesConstant
        {
            Admin=1,
            User
        }

        public enum DifficultyConstant
        {
            Easy=1,
            Medium,
            Hard
        }

        public enum StatusConstant
        {
            InProgress=1,
            Approved,
            Rejected,
            Cancelled,
            Completed
        }
    }
}

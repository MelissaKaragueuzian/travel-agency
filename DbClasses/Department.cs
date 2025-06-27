using System;

namespace TravelAgency_Desktop.DbClasses
{
    public class Department
    {
        public int DepartmentID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int UserCreatedID { get; set; }
        public User CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserModifiedID { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }
    }
}

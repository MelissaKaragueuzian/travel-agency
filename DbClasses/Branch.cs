using System;

namespace TravelAgency_Desktop.DbClasses
{
    public class Branch
    {
        public int BranchID { get; set; }

        public string Name { get; set; }

        public int CityID { get; set; }
        public City City { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int ManagerID { get; set; }
        public Employee Manager { get; set; }

        public int UserCreatedID { get; set; }
        public User CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserModifiedID { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime? DateModified { get; set; }
    }
}

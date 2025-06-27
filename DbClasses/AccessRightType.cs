using System;

namespace TravelAgency_Desktop.DbClasses
{
    public class AccessRightType
    {
        public int AccessRightTypeID { get; set; }
        public string AccessType { get; set; }
        public int UserCreatedID { get; set; }
        public User CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserModifiedID { get; set; }
        public User ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}

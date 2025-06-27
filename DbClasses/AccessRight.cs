using System;
using System.Windows.Forms;

namespace TravelAgency_Desktop.DbClasses
{
    public class AccessRight
    {
        public int AccessRightID { get; set; }
        public int AccessRightTypeID { get; set; }
        public AccessRightType AccessRightType { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int ScreenID { get; set; }
        public Screen Screen { get; set; }

        public int UserCreatedID { get; set; }
        public User CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserModifiedID { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }
    }
}

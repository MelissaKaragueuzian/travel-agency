using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency_Desktop.DbClasses
{
    public class Client
    {
        public int ClientID { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int CityID { get; set; }
        public City City { get; set; }

        public int GenderID { get; set; }
        public Gender Gender { get; set; }

        public int UserCreatedID { get; set; }
        public User CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserModifiedID { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }
    }
}



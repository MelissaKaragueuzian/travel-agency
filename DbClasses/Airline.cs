using System;

namespace TravelAgency_Desktop.DbClasses
{
    public class Airline
    {
        public int AirlineID { get; set; }

        public string Name { get; set; }

        public string Abreviation { get; set; }

        public int CountryID { get; set; }
        public Country Country { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int UserCreatedID { get; set; }
        public User CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserModifiedID { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }
    }
}

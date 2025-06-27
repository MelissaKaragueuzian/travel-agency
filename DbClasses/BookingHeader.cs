using System;

namespace TravelAgency_Desktop.DbClasses
{
    public class BookingHeader
    {
        public int BookingHeaderID { get; set; }

        public int ClientID { get; set; }
        public Client Client { get; set; }

        public int CurrencyID { get; set; }
        public Currency Currency { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public decimal Discount { get; set; }

        public float TotalAmount { get; set; }

        public byte BookingStatus { get; set; }

        public int UserCreatedID { get; set; }
        public User CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserModifiedID { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }
    }
}

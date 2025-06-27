using System;

namespace TravelAgency_Desktop.DbClasses
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int BookingHeaderID { get; set; }
        public BookingHeader BookingHeader { get; set; }

        public int ReservationHeaderID { get; set; }
        public ReservationHeader ReservationHeader { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int PassengerID { get; set; }
        public Passenger Passenger { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public DateTimeOffset FromDate { get; set; }

        public DateTimeOffset ToDate { get; set; }

        public int DepartureID { get; set; }
        public Location Departure { get; set; }

        public int ArrivalID { get; set; }
        public Location Arrival { get; set; }

        public int HotelID { get; set; }
        public Hotel Hotel { get; set; }

        public int UserCreatedID { get; set; }
        public User CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserModifiedID { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }
    }
}

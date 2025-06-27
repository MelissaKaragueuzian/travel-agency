using System;

public class Hotel
{
    public int HotelID { get; set; }

    public string Name { get; set; }

    public int LocationID { get; set; }
    public Location Location { get; set; }

    public decimal Rating { get; set; }

    public string PhoneNumber { get; set; }

    public int UserCreatedID { get; set; }
    public User UserCreated { get; set; }

    public DateTime DateCreated { get; set; }

    public int UserModifiedID { get; set; }
    public User UserModified { get; set; }

    public DateTime DateModified { get; set; }
}

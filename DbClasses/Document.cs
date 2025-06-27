using System;

public class Document
{
    public int DocumentID { get; set; }

    public int PassengerID { get; set; }
    public Passenger Passenger { get; set; }

    public string Number { get; set; }

    public byte[] ScannedPapers { get; set; }

    public int DocumentTypeID { get; set; }
    public DocumentType DocumentType { get; set; }

    public DateTime ExpiryDate { get; set; }

    public int UserCreatedID { get; set; }
    public User CreatedBy { get; set; }

    public DateTime DateCreated { get; set; }

    public int UserModifiedID { get; set; }
    public User ModifiedBy { get; set; }

    public DateTime DateModified { get; set; }

}

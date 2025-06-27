using System;

public class DocumentType
{
    public int DocumentTypeID { get; set; }      

    public string Name { get; set; }

    public int UserCreatedID { get; set; }
    public User CreatedBy { get; set; }

    public DateTime DateCreated { get; set; }

    public int UserModifiedID { get; set; }
    public User ModifiedBy { get; set; }

    public DateTime DateModified { get; set; }
}

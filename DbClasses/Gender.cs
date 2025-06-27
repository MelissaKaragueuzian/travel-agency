using System;

public class Gender
{
    public int GenderID { get; set; }

    public string Name { get; set; }

    public int UserCreatedID { get; set; }
    public User UserCreated { get; set; }

    public DateTime DateCreated { get; set; }

    public int UserModifiedID { get; set; }
    public User UserModified { get; set; }

    public DateTime DateModified { get; set; }
}

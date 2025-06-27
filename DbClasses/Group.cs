using System;

public class Group
{
    public int GroupID { get; set; }

    public string Name { get; set; }

    public int AccessRightID { get; set; }
    public AccessRight AccessRight { get; set; }

    public string Description { get; set; }

    public int UserCreatedID { get; set; }
    public User UserCreated { get; set; }

    public DateTime DateCreated { get; set; }

    public int UserModifiedID { get; set; }
    public User UserModified { get; set; }

    public DateTime DateModified { get; set; }
}

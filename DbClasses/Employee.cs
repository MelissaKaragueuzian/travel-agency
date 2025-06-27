using System;
using TravelAgency_Desktop.DbClasses;

public class Employee
{
    public int EmployeeID { get; set; }

    public string FullName { get; set; }

    public DateTime? HireDate { get; set; }

    public int BranchID { get; set; }
    public Branch Branch { get; set; }  

    public int DepartmentID { get; set; }
    public Department Department { get; set; } 

    public string Position { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public int CountryID { get; set; }
    public Country Country { get; set; } 

    public int GenderID { get; set; }
    public Gender Gender { get; set; }    

    public int CityID { get; set; }
    public City City { get; set; }       

    public string MaritalStatus { get; set; }
            
    public int UserCreatedID { get; set; }
    public User UserCreated { get; set; } 

    public DateTime DateCreated { get; set; }

    public int UserModifiedID { get; set; }
    public User UserModified { get; set; }

    public DateTime DateModified { get; set; }
}

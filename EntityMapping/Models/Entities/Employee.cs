namespace EntityMapping;

public class Employee
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
    public string JobTitle { get; set; }
    public DateTime HireDate { get; set; }
}

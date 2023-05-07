using System.ComponentModel.DataAnnotations;

namespace EntityMapping;

public class EmployeeViewModel
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string DateOfBirth { get; set; }
    [Required]
    public string DepartmentName { get; set; }
    [Required]
    public string JobTitle { get; set; }
    [Required]
    public string HireDate { get; set; }
    [Required]
    public string SalaryFormatted { get; set; }
}
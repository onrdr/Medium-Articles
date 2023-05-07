using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace EntityMapping.Controllers;


[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> Employees = new();

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var employee = Employees.FirstOrDefault(x => x.Id == id);
        if (employee == null)
            return NotFound();

        var model = new EmployeeViewModel
        {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Email = employee.Email,
            DateOfBirth = employee.DateOfBirth.ToString("yyyy-MM-dd"),
            SalaryFormatted = employee.Salary.ToString("C"),
            DepartmentName = employee.Department,
            JobTitle = employee.JobTitle,
            HireDate = employee.HireDate.ToString("yyyy-MM-dd")
        };
        return Ok(model);
    }

    [HttpPost]
    public IActionResult Register(EmployeeViewModel model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var employee = new Employee
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            DateOfBirth = DateTime.Parse(model.DateOfBirth),
            Salary = decimal.Parse(model.SalaryFormatted),
            Department = model.DepartmentName,
            JobTitle = model.JobTitle,
            HireDate = DateTime.Parse(model.HireDate)
        };
        Employees.Add(employee);
        return Ok($"Employee Added Successfully with ID: {employee.Id}");
    }
}


[ApiController]
[Route("api/[controller]")]
public class MappedEmployeeController : ControllerBase
{
    private static List<Employee> MappedEmployees = new();

    private readonly IMapper _mapper;
    public MappedEmployeeController(IMapper mapper) => _mapper = mapper;

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var employee = MappedEmployees.FirstOrDefault(x => x.Id == id);
        if (employee == null)
            return NotFound();

        var model = _mapper.Map<EmployeeViewModel>(employee);
        return Ok(model);
    }

    [HttpPost]
    public IActionResult Register(EmployeeViewModel model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var employee = _mapper.Map<Employee>(model);
        MappedEmployees.Add(employee);
        return Ok($"Employee Added Successfully with ID: {employee.Id}");
    }
}
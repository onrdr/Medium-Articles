using AutoMapper;

namespace EntityMapping.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<EmployeeViewModel, Employee>()
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => DateTime.Parse(src.DateOfBirth)))
            .ForMember(dest => dest.HireDate, opt => opt.MapFrom(src => DateTime.Parse(src.HireDate)))
            .ForMember(dest => dest.Salary, opt => opt.MapFrom(src => decimal.Parse(src.SalaryFormatted)))
            .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.DepartmentName));

        CreateMap<Employee, EmployeeViewModel>()
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth.ToString("yyyy-MM-dd")))
            .ForMember(dest => dest.HireDate, opt => opt.MapFrom(src => src.HireDate.ToString("yyyy-MM-dd")))
            .ForMember(dest => dest.SalaryFormatted, opt => opt.MapFrom(src => src.Salary.ToString("C")))
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department));
    }
}

using AutoMapper;
using ResourceManagement.UI.Models;
using ResourceManagement.UI.ViewModels;

namespace ResourceManagement.UI.MappingConfigurations
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<EmployeeViewModel, Employee>();
            CreateMap<EmployeeViewModel, EmployeeProject>();
        }
    }
}

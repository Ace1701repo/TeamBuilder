using AutoMapper;
using TeamBuilder.Domain.DTOs;
using TeamBuilderAPI.DTOs;
using TeamBuilderAPI.Models;

namespace TeamBuilderAPI.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<EventCentre, EventCentreDTO>().ReverseMap();
            CreateMap<Restaurant, RestaurantDTO>().ReverseMap();
            CreateMap<Team, TeamDTO>().ReverseMap();
            CreateMap<TeamBuilding, TeamBuildingDTO>().ReverseMap();
        }

    }
}

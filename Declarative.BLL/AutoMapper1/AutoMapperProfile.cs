using AutoMapper;
using Declarative.Api.Models.Employee;
using Declarative.Api.Models.Project;
using Declarative.Api.Models.Company;
using Declarative.Api.Models.ProjectLeader;
using Declarative.Api.Models.Task;
using Declarative.DAL.Entities;
using System;
    
namespace Declarative.BLL.AutoMapper1
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // map for EmployeeViewModel from Employee entity
            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position))
                .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectId)).ReverseMap();

            // map for ProjectViewModel from Project entity
            CreateMap<Project, ProjectViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ProjectLeaderId, opt => opt.MapFrom(src => src.ProjectLeaderId))
                .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.CustomerCompanyId, opt => opt.MapFrom(src => src.CustomerCompanyId))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate)).ReverseMap();

            // map for CompanyViewModel from Company entity
            CreateMap<Company, CompanyViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectId)).ReverseMap();

            // map for ProjectLeaderViewModel from ProjectLeader entity
            CreateMap<ProjectLeader, ProjectLeaderViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position))
                .ForMember(dest => dest.ProjectId, opt => opt.MapFrom(src => src.ProjectId)).ReverseMap();

            // map for TaskViewModel from ProjectTask entity
            CreateMap<ProjectTask, TaskViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
                .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority)).ReverseMap();
        }
    }
}

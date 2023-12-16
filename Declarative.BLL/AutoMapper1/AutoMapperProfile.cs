using AutoMapper;
using Declarative.Api.Models.Employee;
using Declarative.DAL.Entities;
using System;


namespace Declarative.BLL.AutoMapper1
{
    public class AutoMapperProfile : Profile

    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeViewModel>();
        }
    }
}

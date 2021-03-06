﻿using AutoMapper;
using AutoMapper.Configuration;
using BusinessHR.Admin.Models;
using BusinessHR.Model;

namespace BusinessHR.Admin
{
    public class AutoMapperConfig
    {
        public void Initialize()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.AllowNullCollections = true;
            cfg.AllowNullDestinationValues = true;

            cfg.CreateMap<Certificate, CertificateViewModel>().ReverseMap().ForMember(
                dest => dest.Employees, opt => opt.Ignore());

            

            cfg.CreateMap<City, CityViewModel>().ForMember(
            dest => dest.CountryName, opt => opt.MapFrom(src => src.Country.Name)).ReverseMap().ForMember(
            dest => dest.Country, opt => opt.Ignore()).ForMember
            (dest => dest.Employees, opt => opt.Ignore()).ForMember
            (dest => dest.Regions, opt => opt.Ignore()).ForMember
            (dest => dest.Companies, opt => opt.Ignore());


            cfg.CreateMap<Country, CountryViewModel>().ReverseMap().ForMember(
                dest => dest.Employees, opt => opt.Ignore()).ForMember(
                dest => dest.Cities, opt => opt.Ignore()).ForMember(
                dest => dest.Companies, opt => opt.Ignore());

            cfg.CreateMap<Permission, PermissionViewModel>().ForMember(
                dest => dest.PermissionTypeName, opt => opt.MapFrom(src => src.PermissionType.Name)).ForMember(
                dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Employee.FullName)).ReverseMap().ForMember(
                dest => dest.PermissionType, opt => opt.Ignore()).ForMember(
                dest => dest.Employee, opt => opt.Ignore());

            cfg.CreateMap<PermissionType, PermissionTypeViewModel>().ReverseMap().ForMember(
                dest => dest.Permissions, opt => opt.Ignore());

            cfg.CreateMap<Position, PositionViewModel>().ForMember(
                dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name)).ReverseMap().ForMember(
                dest => dest.Employees, opt => opt.Ignore()).ForMember(
                dest => dest.Department, opt => opt.Ignore());


            cfg.CreateMap<Region, RegionViewModel>().ForMember(
             dest => dest.CityName,opt => opt.MapFrom(src => src.City.Name)).ReverseMap().ForMember(
                dest => dest.City, opt => opt.Ignore()).ForMember
             (dest => dest.Companies, opt => opt.Ignore()).ForMember
             (dest => dest.Employees, opt => opt.Ignore());

            cfg.CreateMap<Salary, SalaryViewModel>().ForMember(
                dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Employee.FullName)).ReverseMap().ForMember(
                dest => dest.Employee, opt => opt.Ignore());



            cfg.CreateMap<Company, CompanyViewModel>().ForMember(
            dest => dest.CountryName, opt => opt.MapFrom(src => src.Country.Name)).ForMember(
                dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name)).ForMember(
                dest => dest.RegionName, opt => opt.MapFrom(src => src.Region.Name)).ReverseMap().ForMember
             (dest => dest.Departments, opt => opt.Ignore()).ForMember(
            dest => dest.Country, opt => opt.Ignore()).ForMember(
            dest => dest.City, opt => opt.Ignore()).ForMember(
            dest => dest.Region, opt => opt.Ignore());

            cfg.CreateMap<Department, DeparmentViewModel>().ForMember(
                dest => dest.CompanyName,opt => opt.MapFrom(src => src.Company.Name)).ReverseMap().ForMember(
                dest => dest.Positions, opt => opt.Ignore()).ForMember(
                dest => dest.Employees, opt => opt.Ignore()).ForMember
             (dest => dest.Company, opt => opt.Ignore());

            cfg.CreateMap<Employee, EmployeeViewModel>().ForMember(
                dest => dest.CertificateName, opt => opt.MapFrom(src => src.Certificate.Name)).ForMember(
                dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name)).ForMember(
                dest => dest.PositionName, opt => opt.MapFrom(src => src.Position.Name)).ForMember(
                dest => dest.CountryName, opt => opt.MapFrom(src => src.Country.Name)).ForMember(
                dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name)).ForMember(
                dest => dest.RegionName, opt => opt.MapFrom(src => src.Region.Name)).ReverseMap().ForMember(
                dest => dest.Certificate, opt => opt.Ignore()).ForMember(
                dest => dest.Department, opt => opt.Ignore()).ForMember(
                dest => dest.Position, opt => opt.Ignore()).ForMember(
                dest => dest.Country, opt => opt.Ignore()).ForMember(
                dest => dest.City, opt => opt.Ignore()).ForMember(
                dest => dest.Region, opt => opt.Ignore()).ForMember(
                dest => dest.Salaries, opt => opt.Ignore());
            //en altta kalsın
            Mapper.Initialize(cfg);
            
        }
    }
}
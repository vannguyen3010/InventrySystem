﻿using AutoMapper;
using Entities.Identity;
using Entities.Models;
using Shared.DTO.Brand;
using Shared.DTO.Category;
using Shared.DTO.Device;
using Shared.DTO.DeviceAssignment;
using Shared.DTO.Employee;
using Shared.DTO.MaintenanceSchedule;
using Shared.DTO.Office;
using Shared.DTO.ServiceHistory;
using Shared.DTO.Supplier;
using Shared.DTO.User;

namespace InventrySystem
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<UserForRegistrationDto, User>()
                        .ForMember(u => u.UserName, opt => opt.MapFrom(x => GenerateValidUserName(x.Email)));

            CreateMap<Device, DeviceDto>()
                .ForMember(d => d.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(d => d.BrandName, opt => opt.MapFrom(src => src.Brand.Name))
                .ForMember(d => d.SupplierName, opt => opt.MapFrom(src => src.Supplier.Name));
            CreateMap<DeviceForCreationDto, Device>();
            CreateMap<DeviceForUpdateDto, Device>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryForCreationDto, Category>();
            CreateMap<CategoryForUpdateDto, Category>();

            CreateMap<Brand, BrandDto>();
            CreateMap<BrandForCreationDto, Brand>();
            CreateMap<BrandForUpdateDto, Brand>();

            CreateMap<Supplier, SupplierDto>();
            CreateMap<SupplierForCreationDto, Supplier>();
            CreateMap<SupplierForUpdateDto, Supplier>();

            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeForCreationDto, Employee>();
            CreateMap<EmployeeForUpdateDto, Employee>();

            CreateMap<Office, OfficeDto>();
            CreateMap<OfficeForCreationDto, Office>();
            CreateMap<OfficeForUpdateDto, Office>();

            CreateMap<DeviceAssignment, DeviceAssignmentDto>()
                .ForMember(d => d.SerialNumber, opt => opt.MapFrom(src => src.Device.SerialNumber))
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Device.Name))
            .ForMember(d => d.CategoryName, opt => opt.MapFrom(src => src.Device.Category.Name))
            .ForMember(d => d.BrandName, opt => opt.MapFrom(src => src.Device.Brand.Name));
            CreateMap<DeviceAssignmentForCreationDto, DeviceAssignment>();
            CreateMap<DeviceAssignmentForOfficeDto, DeviceAssignment>();
            CreateMap<DeviceAssignmentForUpdateDto, DeviceAssignment>();

            CreateMap<MaintenanceSchedule, MaintenanceScheduleDto>();
            CreateMap<MaintenanceScheduleForCreationDto, MaintenanceSchedule>();
            CreateMap<MaintenanceScheduleForUpdateDto, MaintenanceSchedule>();

            CreateMap<ServiceHistory, ServiceHistoryDto>();
            CreateMap<ServiceHistoryForCreationDto, ServiceHistory>();
            CreateMap<ServiceHistoryForUpdateDto, ServiceHistory>();

            CreateMap<UserForRegistrationDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<UserRole, UserRoleDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<UserRoleForCreationDto, UserRole>();
            CreateMap<UserRoleForUpdateDto, UserRole>();
        }
        private string GenerateValidUserName(string email)
        {
            var atIndex = email.IndexOf('@');
            if (atIndex > 0)
            {
                return email.Substring(0, atIndex);
            }
            return email;
        }
    }
}

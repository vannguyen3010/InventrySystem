﻿using Shared.DTO.DeviceAssignment;
using System.ComponentModel.DataAnnotations;

namespace Shared.DTO.Employee
{
    public class EmployeeForCreationDto
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(60, ErrorMessage = "First Name can't be longer than 60 characters")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(60, ErrorMessage = "Last Name can't be longer than 60 characters")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Employee Number is required")]
        [StringLength(60, ErrorMessage = "Employee Number can't be longer than 60 characters")]
        public string? EmployeeNumber { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [StringLength(60, ErrorMessage = "Position can't be longer than 60 characters")]
        public string? Position { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
    }

    public class EmployeeForUpdateDto
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(60, ErrorMessage = "First Name can't be longer than 60 characters")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(60, ErrorMessage = "Last Name can't be longer than 60 characters")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Employee Number is required")]
        [StringLength(60, ErrorMessage = "Employee Number can't be longer than 60 characters")]
        public string? EmployeeNumber { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [StringLength(60, ErrorMessage = "Position can't be longer than 60 characters")]
        public string? Position { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
    }

    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmployeeNumber { get; set; }
        public string? Position { get; set; }
        public string? Email { get; set; }
        public IEnumerable<DeviceAssignmentDto>? DeviceAssignments { get; set; }
    }

}

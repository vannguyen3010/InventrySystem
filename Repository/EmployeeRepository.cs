﻿using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateEmployee(Employee employee)
        {
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(e => e.LastName)
              .Include(e => e.DeviceAssignments)
                  .ThenInclude(d => d.Device)
                      .ThenInclude(dev => dev.Category)
                  .Include(e => e.DeviceAssignments)
                      .ThenInclude(d => d.Device)
                          .ThenInclude(dev => dev.Brand)
                .ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(Guid employeeId, bool trackChanges)
        {
            return await FindByCondition(employee => employee.Id.Equals(employeeId), trackChanges)

              .Include(e => e.DeviceAssignments)
                  .ThenInclude(d => d.Device)
                      .ThenInclude(dev => dev.Category)
                  .Include(e => e.DeviceAssignments)
                      .ThenInclude(d => d.Device)
                          .ThenInclude(dev => dev.Brand)
                                .FirstOrDefaultAsync();
        }

        public void UpdateEmployee(Employee employee)
        {
            Update(employee);
        }
    }
}

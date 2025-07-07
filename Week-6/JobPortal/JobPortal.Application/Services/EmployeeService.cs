using JobPortal.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Infrastructure.Repositories;
using JobPortal.Infrastructure.Contracts;
using JobPortal.Domain;
namespace JobPortal.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeContract _employeeRepository;
        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }
        public async Task AddEmployeeAsync(EmployeeDTO employee)
        {
            try
            {
                // Convert EmployeeDTO to Employee domain model
                var employeeEntity = new Employee
                {
                    EmployeeId = employee.EmployeeId,
                    EmployeeName = employee.EmployeeName,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    Organization = employee.Organization
                };
                // Call the repository method to add the employee
                await _employeeRepository.AddEmployeeAsync(employeeEntity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteEmployeeAsync(string employeeId)
        {
           await _employeeRepository.DeleteEmployeeAsync(employeeId);
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAsync()
        {
            try
            {
                var employees = await _employeeRepository.GetAllEmployeesAsync();
                // Convert the Employee domain model to EmployeeDTO
                var employeeDTOs = employees.Select(e => new EmployeeDTO
                {
                    EmployeeId = e.EmployeeId,
                    EmployeeName = e.EmployeeName,
                    Email = e.Email,
                    PhoneNumber = e.PhoneNumber,
                    Organization = e.Organization
                });
                return employeeDTOs;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<EmployeeDTO> GetEmployeeByIdAsync(string employeeId)
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeByIdAsync(employeeId);
                if (employee == null)
                {
                    return null; // or throw an exception if preferred
                }
                // Convert the Employee domain model to EmployeeDTO
                var employeeDTO = new EmployeeDTO
                {
                    EmployeeId = employee.EmployeeId,
                    EmployeeName = employee.EmployeeName,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    Organization = employee.Organization
                };
                return employeeDTO;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task UpdateEmployeeAsync(EmployeeDTO employee)
        {
            try
            {
                // Convert EmployeeDTO to Employee domain model
                var employeeEntity = new Employee
                {
                    EmployeeId = employee.EmployeeId,
                    EmployeeName = employee.EmployeeName,
                    Email = employee.Email,
                    PhoneNumber = employee.PhoneNumber,
                    Organization = employee.Organization
                };
                // Call the repository method to update the employee
                return _employeeRepository.UpdateEmployeeAsync(employeeEntity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

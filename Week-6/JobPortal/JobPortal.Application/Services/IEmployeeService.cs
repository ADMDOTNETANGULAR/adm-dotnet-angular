using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Application.DTOs;
namespace JobPortal.Application.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAsync();
        Task<EmployeeDTO> GetEmployeeByIdAsync(string employeeId);
        Task AddEmployeeAsync(EmployeeDTO employee);
        Task UpdateEmployeeAsync(EmployeeDTO employee);
        Task DeleteEmployeeAsync(string employeeId);
    }
}

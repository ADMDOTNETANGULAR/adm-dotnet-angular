using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Domain;
using JobPortal.Infrastructure.Contracts;
using JobPortal.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
namespace JobPortal.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeContract
    {
        private readonly JobPortalDbContext _context;
        public EmployeeRepository()
        {
            _context = new JobPortalDbContext();
        }
        public async Task AddEmployeeAsync(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteEmployeeAsync(string employeeId)
        {
            try
            {
                var employee = await _context.Employees.FindAsync(employeeId);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            try
            {
                return await _context.Employees.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Employee> GetEmployeeByIdAsync(string employeeId)
        {
            try
            {
                return await _context.Employees.FindAsync(employeeId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                //_context.Entry(employee).State = EntityState.Modified; // Ensure the entity state is set to Modified
                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using JobPortal.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JobPortal.Application.DTOs;
namespace JobPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        // Constructor injection for IEmployeeService
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        //public EmployeeController()
        //{
        //    employeeService=new EmployeeService();
        //}
        //Endpoints
        // GET: api/employee
        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await employeeService.GetAllEmployeesAsync(); // Call the service to get all employees
            return Ok(employees); // Return 200 OK with the list of employees in JSON format
        }
        // GET: api/employee/{id}
        [HttpGet("GetEmployeeById/{id}")]
        public async Task<IActionResult> GetEmployeeById([FromRoute]string id)
        {
            try
            {
                var employee = await employeeService.GetEmployeeByIdAsync(id); // Call the service to get an employee by ID
                if (employee == null)
                {
                    return NotFound("Invalid Employee Id"); // Return 404 Not Found if the employee does not exist
                }
                return Ok(employee); // Return 200 OK with the employee details in JSON format
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        // POST: api/employee
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeDTO employee)
        {
           if(ModelState.IsValid)
            {
                try
                {
                    if (employee == null)
                    {
                        return BadRequest("Employee data is null"); // Return 400 Bad Request if the employee data is null
                    }
                    await employeeService.AddEmployeeAsync(employee); // Call the service to add a new employee
                    return StatusCode(200, employee); // Return 200 OK with the added employee details in JSON format
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }
            return BadRequest(ModelState); // Return 400 Bad Request if the model state is invalid
        }
        // PUT: api/employee
        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] EmployeeDTO employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (employee == null)
                    {
                        return BadRequest("Employee data is null"); // Return 400 Bad Request if the employee data is null
                    }
                    await employeeService.UpdateEmployeeAsync(employee); // Call the service to update an existing employee
                    return StatusCode(200, employee); // Return 200 OK with the updated employee details in JSON format
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }
            return BadRequest(ModelState); // Return 400 Bad Request if the model state is invalid
        }
        // DELETE: api/employee/{id}
        [HttpDelete("DeleteEmployee/{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    return BadRequest("Employee Id is null or empty"); // Return 400 Bad Request if the employee ID is null or empty
                }
                await employeeService.DeleteEmployeeAsync(id); // Call the service to delete an employee by ID
                return Ok($"Employee with Id {id} deleted successfully"); // Return 200 OK with a success message
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message); // Return 500 Internal Server Error with the exception message
            }
        }
    }
}

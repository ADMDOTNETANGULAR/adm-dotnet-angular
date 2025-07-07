using JobPortal.Application.DTOs;
using JobPortal.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }
        public async Task<IActionResult> Index() //get all employees
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            return View(employees);
        }
        public async Task<IActionResult> Details(string id) //get employee by id
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        [HttpGet]
        public async Task<IActionResult> Create() //create employee
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeDTO employee) //create employee
        {
            if (ModelState.IsValid)
            {
                await _employeeService.AddEmployeeAsync(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string id) //delete employee
        {
            await _employeeService.DeleteEmployeeAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id) //edit employee
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeDTO employee) //edit employee
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _employeeService.UpdateEmployeeAsync(employee);
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch (Exception ex)
            {

                return View("Error");
            }

        }
    }
}

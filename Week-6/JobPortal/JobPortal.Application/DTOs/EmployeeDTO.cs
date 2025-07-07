using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace JobPortal.Application.DTOs
{
    public class EmployeeDTO
    {
        [Required(ErrorMessage ="Pls Enter Id")]

        public string EmployeeId { get; set; }
        [Required(ErrorMessage = "Pls Enter Name")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Pls Enter Email")]
        [EmailAddress(ErrorMessage = "Pls Enter Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pls Enter Phone")]
        [RegularExpression(@"^[7-9]{1}\d{9}$", ErrorMessage = "Pls Enter Valid Phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Pls Enter Organisation")]
        public string Organization { get; set; }
    }
}

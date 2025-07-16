using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JobPortal.Domain
{
    public class Employee
    {
        [Key]
        [Column(TypeName ="char")]
        [StringLength(5)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Organization { get; set; }
        public string UserId { get; set; } // Foreign key to User
        [ForeignKey("UserId")]
        public User User { get; set; } // Navigation property to User
    }
}

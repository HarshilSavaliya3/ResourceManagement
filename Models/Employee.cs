using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ResourceManagement.UI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; } = string.Empty;

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        public int ManagerId { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
        public List<EmployeeProject>? EmployeeProjects { get; set; }
    }
}

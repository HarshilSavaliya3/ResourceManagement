using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ResourceManagement.UI.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required]
        [DisplayName("Role")]
        public string RoleName { get; set; } = string.Empty;
        public Employee? Employee { get; set; }
        public List<ProjectRole>? ProjectRoles { get; }
        public EmployeeProject? EmployeeProject { get; set; }

    }
}

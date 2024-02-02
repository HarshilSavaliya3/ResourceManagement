using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace ResourceManagement.UI.Models
{
    public class EmployeeProject
    {
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }
        public int Allocation { get; set; }
        public Employee Employee { get; set; } = null!;
        public Project Project { get; set; } = null!;
        public Role Role { get; set; } = null!;
    }
}

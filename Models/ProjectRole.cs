using System.ComponentModel.DataAnnotations;

namespace ResourceManagement.UI.Models
{
    public class ProjectRole
    {
        public int ProjectId { get; set; }
        public int RoleId { get; set; }
        public int ResourceCount { get; set; }
        public Role Role { get; set; } = null!;
        public Project Project { get; set; } = null!;
    }
}

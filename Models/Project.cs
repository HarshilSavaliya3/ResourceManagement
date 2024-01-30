using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ResourceManagement.UI.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; } = string.Empty;

        [Required]
        public string Status { get; set; } = string.Empty;
        public List<EmployeeProject>? EmployeeProjects { get; }
        public List<ProjectRole>? ProjectRoles { get; set; }
    }
}

using ResourceManagement.UI.Models;
using System.ComponentModel;

namespace ResourceManagement.UI.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }

        [DisplayName("Project")]
        public int ProjectId { get; set; }

        public int Allocation { get; set; }
    }
}

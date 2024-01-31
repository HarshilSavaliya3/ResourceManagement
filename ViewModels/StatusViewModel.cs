using Microsoft.AspNetCore.Mvc.Rendering;

namespace ResourceManagement.UI.ViewModels
{
    public class StatusViewModel
    {
        public List<SelectListItem> Status { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "On Going", Text = "On Going" },
            new SelectListItem { Value = "Completed", Text = "Completed" },
            new SelectListItem { Value = "Future", Text = "Future"  },
        };
    }
}

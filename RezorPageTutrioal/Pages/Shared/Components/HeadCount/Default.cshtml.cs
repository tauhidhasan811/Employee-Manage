using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace RezorPageTutrioal.Pages.Shared.Components.HeadCount
{
    public class DefaultModel : PageModel
    {
        public List<DeptHeadCount> DeptHeadCounts { get; set; }

        public DefaultModel()
        {
            DeptHeadCounts = new List<DeptHeadCount>();
        }

        public void OnGet()
        {
            // Example data, replace with actual data retrieval logic
            DeptHeadCounts.Add(new DeptHeadCount { Department = "HR", Count = 10 });
            DeptHeadCounts.Add(new DeptHeadCount { Department = "IT", Count = 25 });
            DeptHeadCounts.Add(new DeptHeadCount { Department = "Finance", Count = 15 });
        }
    }

    public class DeptHeadCount
    {
        public string Department { get; set; }
        public int Count { get; set; }
    }
}

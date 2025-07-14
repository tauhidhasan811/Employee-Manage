using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RezorPageTutrioal.Pages
{
    public class IndexModel(ILogger<IndexModel> logger) : PageModel
    {
        private readonly ILogger<IndexModel> _logger = logger;
        public required string Message { get; set; }

        public void OnGet()
        {
            Message = "Tauhid's World!! And Time is " + DateTime.Now.ToLongTimeString() ;
        }
    }
}

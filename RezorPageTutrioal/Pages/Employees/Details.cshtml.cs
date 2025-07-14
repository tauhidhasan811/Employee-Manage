using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesToutrial.Models;
using RazorPagesTutrioal.Services;

namespace RezorPageTutrioal.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository? employeeRepository;
        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [BindProperty(SupportsGet = true)]
        public string Message { get; set; }

        public Employee Employee { get; private set; }

        public IActionResult OnGet(int id)
        {
            Employee = employeeRepository.GetEmployee(id);
            if(Employee == null)
            {
                return Redirect("/NotFound");
            }
            return Page();
            
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutrioal.Services;

namespace RezorPageTutrioal.Pages.Employees
{
    public class IndexModel: PageModel
    {
        private readonly IEmployeeRepository employeeRepository;
        public IEnumerable<RazorPagesToutrial.Models.Employee> Employees { get; set; }
        public IndexModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public void OnGet()
        {
            Employees = employeeRepository.GetAllEmployees();
        }   
    }
}

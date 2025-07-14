using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesToutrial.Models;
using RazorPagesTutrioal.Services;

namespace RezorPageTutrioal.Pages.V2
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTutrioal.Services.AppDbContext _context;

        public IndexModel(RazorPagesTutrioal.Services.AppDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}

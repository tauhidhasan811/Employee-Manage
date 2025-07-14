using RazorPagesToutrial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesTutrioal.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Tauhid", Department = Dept.IT, Email = "tauhid@gmail.com", PhotoPath = "avatar1.png" },
                new Employee() { Id = 2, Name = "Sakib", Department = Dept.HR, Email = "hasan@gmail.com", PhotoPath = "avatar2.png" },
                new Employee() { Id = 3, Name = "Rakib", Department = Dept.Payroll, Email = "boss@gmail.com", PhotoPath = "avatar3.png" },
                new Employee() { Id = 4, Name = "Rahim", Department = Dept.IT, Email = "mafia@gmail.com", PhotoPath = "avatar4.png" },
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}

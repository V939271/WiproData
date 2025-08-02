using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreDemo.Pages
{
    public class EmployeeShowModelModel : PageModel
    {
        public List<Employee>? Employees { get; set; }
        public void OnGet()
        {
            Employees = new List<Employee>
            {
                new Employee{Empno=1,Name="Venkat",Basic=4441},
                new Employee{Empno=2,Name="Kasi",Basic=5555 },
                new Employee{Empno=3,Name="Siva",Basic=6666},
            };
        }
    }
}

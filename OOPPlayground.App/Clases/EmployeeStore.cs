using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.app.Clases
{
    public class EmployeeStore : IEmployeStore
    {
        private List<Employee> employees;

        public EmployeeStore()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DeleteEmployee(Guid id)
        {
            var employeeToRemove = employees.Find(x => x.Id == id);
            employees.Remove(employeeToRemove);
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;    
                
        }

        public Employee GetEmployeeById(Guid id)
        {
            return employees.Find(x => x.Id == id);
        }
    }
}

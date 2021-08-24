using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.app.Clases
{
    public interface IEmployeStore
    {
        public Employee GetEmployeeById(Guid id);
        public List<Employee> GetAllEmployees();

        public void AddEmployee(Employee employee);
        public void DeleteEmployee(Guid id);
    }
}

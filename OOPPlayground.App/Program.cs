using OOPPlayground.app.Clases;
using System;

namespace OOPPlayground.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee zoli= new Employee("Zoli","Kov");

            IEmployeStore store = new EmployeeStore();

            store.AddEmployee(zoli);
            var randomId = Guid.NewGuid();
            var secondEmployee = new Employee("Donald", "Trump");
            secondEmployee.Id = randomId;
            store.AddEmployee(secondEmployee);

            store.AddEmployee(new Employee("Hilary", "Clinton"));
            var allEmployees = store.GetAllEmployees();

            var donaldTrump = store.GetEmployeeById(randomId);
            Employee.GetSomeRandomString();
            Console.WriteLine("The count of employees:" + allEmployees.Count); 
            foreach(var employee in allEmployees)
            {
                Console.WriteLine("The employee:" + employee.GetUserSerilized());

            }
            Console.WriteLine("Query result:" + donaldTrump.GetFullName());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonellPayrollSystem
{
    internal class Employee
    {
        private string name = string.Empty;
        private string salary = string.Empty;
        public Employee(string nameE, string salaryE) {

            name = nameE;
            salary = salaryE;
        
        }

        public void getEmployeeDetails(Employee emp)
        {
            if (name == string.Empty)
            {
                Console.WriteLine("Sorry, no employee in the register");
                return;
            }

            Console.WriteLine("Employee's name: " + emp.name);
            Console.WriteLine("Employee's salary: " + emp.salary);
        }
    }
}

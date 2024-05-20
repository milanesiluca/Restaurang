using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonellPayrollSystem
{
    internal class Register
    {

        private Employee[] employeesList = Array.Empty<Employee>();

        public void addEmplyee()
        {
            Console.Write("Insert the emplyee's name: ");
            string nameP = Console.ReadLine();

            Console.Write("Insert the Salary in USD: ");
            string salaryP = Console.ReadLine();

            Employee newEmp = new Employee(nameP, salaryP);
            employeesList.Append(newEmp);
        }


        public void printEmplyeeList() {

            int listNum = getNumberOfEmployee();
            if (listNum == 0) {
                Console.WriteLine("no employees in the list");
            }

            foreach (Employee employee in employeesList)
            {
                employee.getEmployeeDetails(employee);
            }
        
        }

        public int getNumberOfEmployee() => employeesList.Length; 

    }
}

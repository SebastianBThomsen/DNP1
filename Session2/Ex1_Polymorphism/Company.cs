using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ex1_Polymorphism
{
    public class Company
    {
        //private ArrayList employeeList = new();
        public List<Employee> Employees { get; set; } = new();
        
        public double GetMonthlySalaryTotal()
        {
            /*
            double totalSalary = 0;
            foreach (Employee employee in employeeList)
            {
                totalSalary += employee.GetMonthlySalary();
            }
            return totalSalary;*/

            return Employees.Sum(employee => employee.GetMonthlySalary());
        }

        public void HireNewEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
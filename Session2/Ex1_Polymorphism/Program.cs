using System;

namespace Ex1_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new FullTimeEmployee("Peter", 35000);
            Employee employee2 = new PartTimeEmployee("Hans", 500, 30);
            Company company = new();
            company.HireNewEmployee(employee1);
            company.HireNewEmployee(employee2);

            Console.WriteLine(company.GetMonthlySalaryTotal());
        }
    }
}
using System;
using MathLib;

namespace S1_Ex5_MathInNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(2,5));
            
            double[] numbers = {3.5,5,6};
            
            Console.WriteLine(Calculator.Add(numbers));
            
            Console.WriteLine(Calculator.Add(new[] {3,3,3.5}));

            Console.WriteLine("Insert first number:");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insert two number:");
            int n2 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine(Calculator.DisplayLargest(n1,n2));
            
        }
    }
}
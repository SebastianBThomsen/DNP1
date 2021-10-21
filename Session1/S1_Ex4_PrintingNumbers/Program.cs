using System;

namespace S1_Ex4_PrintingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new();
            p.PrintEvenNumbersBetweenZeroAnd(10);
            p.PrintUnevenNumbersBetweenZeroAnd(10);
            p.PrintNumbersDivisibleByY(5,2);
        }
    }
}
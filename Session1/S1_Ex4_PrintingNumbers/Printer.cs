using System;

namespace S1_Ex4_PrintingNumbers
{
    public class Printer
    {
        public void PrintEvenNumbersBetweenZeroAnd(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        public void PrintUnevenNumbersBetweenZeroAnd(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        public void PrintNumbersDivisibleByY(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                if (i % y == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
using System;
using Test;

namespace HumanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanPersistence persistence = new();
            Console.WriteLine(persistence.ReturnObject().ToString());
            
            
        }
    }
}
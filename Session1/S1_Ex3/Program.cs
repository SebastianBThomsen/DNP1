using System;

namespace S1_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person person = new();
            person.Name = "Andreas";
            */
            Person person = new()
            {
                Name = "Andreas"
            };
            
            person.Introduce();
        }
    }
}
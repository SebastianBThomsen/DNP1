using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Ex1_JsonIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Frederik", "Marker", 22, 180, false, 'M', new[] {"Nothing", "nothing"});
            Person p2 = new Person("Sander", "Kirchert", 26, 182, false, 'M', new[] {"Motorcross", "Coding"});
            Person p3 = new Person("Sebastian", "Thomsen", 24, 190, false, 'M', new[] {"Gymnastics", "Wowe"});

            List<Person> bigList = new();
            bigList.Add(p1);
            bigList.Add(p2);
            bigList.Add(p3);

            String serialized = JsonSerializer.Serialize(bigList);
            Console.WriteLine(serialized);
            
            string jsonFormatted = JsonSerializer.Serialize(bigList, new JsonSerializerOptions {    WriteIndented = true});
            Console.WriteLine(jsonFormatted);
        }
    }
}
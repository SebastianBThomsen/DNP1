using System;

namespace Test
{
    public class Class1
    {
        static void Main(string[] args)
        {
            PersonPersistence persistence = new PersonPersistence();
            persistence.StoreObjects(bigList);
            persistence.ReturnObject().ForEach(person => Console.Write(person.FirstName));
        }
    }
}
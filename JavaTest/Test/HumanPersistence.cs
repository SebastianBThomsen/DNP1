using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Test
{
    public class HumanPersistence
    {
        /* public void StoreObjects(List<Person> persons)
        {
            string jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText("C:/test/person.txt", jsonFormatted);
        }
        */

        public List<Human> ReturnObject()
        {
            string s = File.ReadAllText("C:/test/document.json");

            return JsonSerializer.Deserialize<List<Human>>(s);
        }
    }
}
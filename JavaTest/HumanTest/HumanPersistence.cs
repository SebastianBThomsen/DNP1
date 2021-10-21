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

        public Human ReturnObject()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            
            string s = File.ReadAllText("C:/Users/Bruger/IdeaProjects/ObjectTransfer/document.json");

            return JsonSerializer.Deserialize<Human>(s, options);
        }
    }
}
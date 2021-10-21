using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Ex1_JsonIntro;

namespace Ex2_Json_File_Storage
{
    public class PersonPersistence
    {
        public void StoreObjects(List<Person> persons)
        {
            string jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText("C:/test/person.txt", jsonFormatted);
        }

        public List<Person> ReturnObject()
        {
            string s = File.ReadAllText("C:/test/person.txt");
            
            return JsonSerializer.Deserialize<List<Person>>(s);
        }
    }
}
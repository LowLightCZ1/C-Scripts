using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] agrs)
        {
            static async Task<TagSet> parseTagSetFromFile(string file)
            {
                string fileContents = await File.ReadAllTextAsync(file);
                return parseTagSet(fileContents);
            }
            
            static TagSet parseTagSet (string contents)
            {
                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();
                return deserializer.Deserialize<TagSet>(contents);
            }

            Task<TagSet> yamlObject = parseTagSetFromFile("tags.yml");



           

            /*var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();*/

            // try{
            //     var result = deserializer.Deserialize<Person>(content);
    
    
            //     Console.WriteLine($"Name: {result.Name}");
            //     Console.WriteLine($"Sums: {result.Sums}");
            // }
                
                
             
            // catch (Exception ex){   
            //     Console.WriteLine($"Deserialization failed: {ex.Message}");
            // }
            
            

            int dot = 600;
            int line = 900;

            Console.Beep(1000, dot);
            Console.Beep(1000, line); //Beep after a code is running

        }
    }

    public class TagSet
    {
        public List<Tag> Tags { get; set; }
    }

    public class Tag 
    {
        public string Name { get; set; }
    }

}
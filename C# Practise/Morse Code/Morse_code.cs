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
            // static async Task<TagSet> ParseTagSetFromFile(string file){
            //     string fileContents = await File.ReadAllTextAsync(file);
            //     return ParseTagSet(fileContents);
            // }
            // static TagSet ParseTagSet (string contents){
            //     var deserializer = new DeserializerBuilder()
            //         .WithNamingConvention(CamelCaseNamingConvention.Instance)
            //         .Build();
            //     return deserializer.Deserialize<TagSet>(contents);
            // }

           

            var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

            try{
                var result = deserializer.Deserialize<Person>(content);
    
    
                Console.WriteLine($"Name: {result.Name}");
                Console.WriteLine($"Sums: {result.Sums}");
            }
                
                
             
            catch (Exception ex){   
                Console.WriteLine($"Deserialization failed: {ex.Message}");
            }
            
            

            int dot = 600;
            int line = 900;

            Console.Beep(1000, dot);
            Console.Beep(1000, line); //Beep after a code is running

        }
    }

    public class Person
    {
    public string Name { get; set; }
    public int Sums { get; set;}
    }


}
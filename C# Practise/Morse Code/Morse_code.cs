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
            static async Task<TagSet> ParseTagSetFromFile(string file){
                string fileContents = await File.ReadAllTextAsync(file);
                return ParseTagSet(fileContents);
            }
            static TagSet ParseTagSet (string contents){
                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();
                return deserializer.Deserialize<TagSet>(contents);
            }

            // var filePath = @"C# Practise/Morse Code/tags.yml";
            // var fileContent = File.ReadAllText(filePath);

            // var deserializer = new DeserializerBuilder().Build();
            // var objectFromYaml = deserializer.Deserialize<Tag>(fileContent);

            int dot = 600;
            int line = 900;

            Console.Beep(1000, dot);
            Console.Beep(1000, line); //Beep after a code is running

        }
    }

    public class TagSet{
        public List<Tag> Tags { get; set;}
    }

    public class Tag {
        public string Name { get; set;}

        public List<string> Synonyms { get; set;}
    }
}
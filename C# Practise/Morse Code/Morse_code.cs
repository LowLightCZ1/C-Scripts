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
            static TagSet ParseMorseSet (string contents)
            {
                var deserializer = new DeserializerBuilder()
                    // .WithNamingConvention(CamelCaseNamingConvetion.Instance)
                    .Build();
                return deserializer.Deserialize<TagSet>(contents);
            }


            int dot = 600;
            int line = 900;

            Console.Beep(1000, dot);
            Console.Beep(1000, line); // Beep after a code is running

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
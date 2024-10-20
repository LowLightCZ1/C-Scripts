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
            // static async Task<TagSet> parseTagSetFromFile(string file)
            // {
            //     string fileContents = await File.ReadAllTextAsync(file);
            //     return parseTagSet(fileContents);
            // }
            
            // static TagSet parseTagSet (string contents)
            // {
            //     var deserializer = new DeserializerBuilder()
            //         .WithNamingConvention(CamelCaseNamingConvention.Instance)
            //         .Build();
            //     return deserializer.Deserialize<TagSet>(contents);
            // }

            // Task<TagSet> yamlObject = parseTagSetFromFile("tags.yml");
            
            // Console.WriteLine(yamlObject);

            int dot = 600;
            int line = 900;

            Dictionary<char, string> morse = new Dictionary<char, string>(); // Create Dictionary

            morse.Add('A', ".-");
            morse.Add('B', "-...");
            morse.Add('C', "-.-.");
            morse.Add('D', "-..");
            morse.Add('E', ".");
            morse.Add('F', "..-.");
            morse.Add('G', "--.");
            morse.Add('H', "....");
            morse.Add('I', "..");
            morse.Add('J', ".---");
            morse.Add('K', "-.-");
            morse.Add('L', ".-..");
            morse.Add('M', "--");
            morse.Add('N', "-.");
            morse.Add('O', "---");
            morse.Add('P', ".--.");
            morse.Add('Q', "--.-");
            morse.Add('R', ".-.");
            morse.Add('S', "...");
            morse.Add('T', "-");
            morse.Add('U', "..-");
            morse.Add('V', "...-");
            morse.Add('W', ".--");
            morse.Add('X', "-..-");
            morse.Add('Y', "-.--");
            morse.Add('Z', "--..");

            string text = "hello world";

            for (int i = 0; i < text.Length; i++) // Converting text to Morse
            {
                char textChar = Char.ToUpper(text[i]);
                if (textChar == ' ') {
                    continue;
                }
                
                for (int j = 0; j < morse[textChar].Length; j++) // Coverting to individual beeps
                {
                    char morseChar = morse[textChar][j];
                    Console.Write(morseChar);
                    if (morseChar == '.')
                    {
                        Console.Beep(1000, dot);
                    }
                    else
                    {
                        Console.Beep(1000, line);
                    }
                }
            }
        }
    }
    // public class TagSet
    // {
    //     public List<Tag> Tags { get; set; }
    // }

    // public class Tag 
    // {
    //     public string Name { get; set; }
    // }
}
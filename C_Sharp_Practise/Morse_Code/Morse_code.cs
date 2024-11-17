using System.Runtime.Versioning;
using System;

namespace Morse_Code
{    
    class Program
    {
        [SupportedOSPlatform("windows")]
        static void Main(string[] agrs)
        {

            Console.WriteLine("Zadej tect který chceš zakodovat:");
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string text = Console.ReadLine();

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

            #pragma warning disable CS8602 // Dereference of a possibly null reference.
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
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
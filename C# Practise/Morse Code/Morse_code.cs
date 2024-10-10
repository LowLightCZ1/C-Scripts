using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MyProgram
{
     class Program
    {
        static void Main(string[] agrs)
        {
            string text = "Hi";
            string map = File.ReadAllText("morse.json");
            
            
            
            int dot = 600;
            int line = 900;
           
            Console.Beep(1000, dot);
            Console.Beep(1000, line); // Beep after a code is running

            


        }
    }
}
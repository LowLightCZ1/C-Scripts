using System;
using System.Collections.Generic;

namespace MyProgram
{
     class Program
    {
        static void Main(string[] agrs)
        {
            Dictionary<int, string> Morse = new();

            Morse.Add(1, "Hello");
            
            
            
            int dot = 600;
            int line = 900;
           
            Console.Beep(1000, dot);
            Console.Beep(1000, line); // Beep after a code is running

            Console.WriteLine(Morse[1]);


        }
    }
}
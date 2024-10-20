using System;

namespace OutputProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey!"); // Write in one line
            Console.WriteLine("Hello!"); // "String literal" + Make new whole line

            Console.WriteLine("\tBroCode"); // Example of Escape Sequences

            Console.ReadKey(); // Stop program only after you press key in terminal
        }
    }   
}

/* Escape Sequences
             * \a = Bell(alert)
             * \b = Backspace
             * \f = Form feed
             * \n = New line
             * \r = Carriage return
             * \t = Horizaontal tab
             * \v = Vertical tab
             * \' = Single quotation mark
             * \" = Double quotation mark
             * \\ = Backslash
             * \? = Literal quotation mark
             */

using System;
using static System.Linq.Enumerable;


namespace Posloupnost
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Fib(4));
            Console.WriteLine(FibRek(6));
        }

        private static int FibRek(int n)
        {   
           return  (n < 2)? n : Fib(n - 1) + Fib(n - 2);
        }

        public static int Fib(int n) 
        {
            if(n == 0) {
                return 0;
            }
           
            int prev = 0;
            int fib = 1;
            
            for (int i = 1; i < n; i++)
            {
                int sum = prev + fib;
                prev = fib;
                fib = sum;
            }
            return fib;
        }
    }
    
}
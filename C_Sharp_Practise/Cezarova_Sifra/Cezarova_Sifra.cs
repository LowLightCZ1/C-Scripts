using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sifra
{
    class Program
    {
        static void Main(string[] args) // Vypisuje zašifrovaný a dešifrovaný text
        {
            string text = Console.ReadLine();

            string cipherText = CezarEncrypt(text, 3);
            string plainText = CezarDecrypt(cipherText, 3);

            Console.WriteLine(cipherText);
            Console.WriteLine(plainText);
            
        }
        private static char Sifra(char ch, int key) 
        {
            if(!char.IsLetter(ch)){
                return ch;
            }

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset); 
        }

        public static string CezarEncrypt(string inputText, int key) // Zašifrování textu
        {
            string outputText = string.Empty;

            foreach(char i in inputText){
                outputText += Sifra(i, key);
            }   
            return outputText;
        }

        public static string CezarDecrypt(string inputText, int key) //Dešifrování 
        {
            return CezarEncrypt(inputText, 26 - key);
        }
        
    }
}
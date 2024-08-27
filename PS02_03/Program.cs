using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_03
{
    internal class Program
    {
        public static void ConsonantOrVowel(char inputChar)

        {
            inputChar = char.ToLower(inputChar);

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

            if (inType(vowels, inputChar)) 
            { 
                Console.WriteLine("Vowel");
            }

            else if (inType(consonants, inputChar))
            {
                Console.WriteLine("Consonant");

            }
            else
            {
                Console.WriteLine("Invalid character");


            }
        }

        public static bool inType(char[] array, char target)
        {
            foreach (char item in array)
            {
                if (item == target)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a random character: ");
            char character = Convert.ToChar(Console.ReadLine());

            ConsonantOrVowel(character);

            Console.ReadKey();
            
        }
    }
}

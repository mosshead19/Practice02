using System;

namespace PS02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to check if it's a palindrome");
            string input = Console.ReadLine();
            if (IfPalindrome(input))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }

        static bool IfPalindrome(string input)
        {
            string lowercase = input.ToLower();
            int lengthInput = lowercase.Length;
            string backwards = "";
            for (int i = lengthInput - 1; i >= 0; i--)
            {
                backwards += lowercase[i]; 
            }
            return backwards == lowercase;
        }
    }
}

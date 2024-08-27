using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_05
{
    internal class Program
    {

        public static int[] CountCharacters(string input)
        {
            // Create an array to store counts for ASCII characters
            int[] counts = new int[128]; // Assuming ASCII characters only

            foreach (char c in input)
            {
                if (c < counts.Length) 
                {
                    counts[c]++;
                }
            }

            return counts;
        }
        static void Main(string[] args)
        {
            string input = "abcdefggggiiii";

            int[] charCounts = CountCharacters(input);

        //print counts
            for (int i = 0; i < charCounts.Length; i++)
            {
                if (charCounts[i] > 0)
                {
                    //converts an integer index i back into its corresponding character
                    char c = (char)i;
                    Console.WriteLine($"{c}: {charCounts[i]}");
                }
            }
            Console.ReadKey();

        }
    }
}

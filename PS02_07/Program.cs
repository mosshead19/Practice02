using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_07
{
    internal class Program
    {
        public static int CalculateDigitSum(int[] number)
        {
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3,4 };

            Console.WriteLine(CalculateDigitSum(nums));
            Console.ReadKey();
        }
    }
}

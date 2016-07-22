using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onParAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem 1

            Console.WriteLine("Enter a number to sum.");
            int a = int.Parse(Console.ReadLine());

            int[] arr = new int[] { a };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
























            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the position of the number you desire to find:");
            int n = Int32.Parse(Console.ReadLine());

            FindNthNumberinSeries(n);

        }

        public static int FindNthNumberinSeries (int n)
        {
            int number = n - 1;


            int[] Series = new int[number + 1];
            Series[0] = 0;
            Series[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                Series[i] = Series[i - 2] + Series[i - 1];
            }

            Console.WriteLine(Series[number] + " is the number of the Fibonacci series in that position of the array.");
            Console.WriteLine("  ");
            Console.WriteLine("Do you want to see the Fibonacci series up to the number you've chosen? Please answer yes or no. ");
            var response = Console.ReadLine();

            if (response == "yes")
            {
                Console.WriteLine("Please wait while we process your request ... ... ... ");
                Console.ReadLine();
            }
            else if (response == "no")
            {
                Console.WriteLine("Cool bro, good choice.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This option is not available. Please do not try again.");
                Console.ReadLine();
            }

            return Series[number];
        }
        

        // TRY using Recursive func
        // Complete the second part in order to print out all of the series up to the chosen position in the series



    }
}

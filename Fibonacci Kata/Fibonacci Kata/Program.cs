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
            Console.WriteLine("Give the position of the number you desire: ");
            int n = Int32.Parse(Console.ReadLine());

            GiveTheNthNumber(n);
        }

        public static int GiveTheNthNumber(int n)
        {
            int FibNumber = n - 1;
            int[] Series = new int[FibNumber + 1];
            Series[0] = 0;
            Series[1] = 1;

            for (int i = 2; i <= FibNumber; i++)
            {
                Series[i] = Series[i - 2] + Series[i - 1];
            }
            Console.WriteLine(Series[FibNumber] + " is the Fibonacci number at the Nth position you asked for.");
            Console.WriteLine("  ");
            Console.WriteLine("Do you want to see the entire sequence up to the position you asked for? Possibly answer with yes or no.");
            var response = Console.ReadLine();

            if (response == "yes")
            {
                Console.WriteLine("Please stay on the line while we deal with your request... ... ...");
                Console.ReadLine();
            }
            else if (response == "no")
            {
                Console.WriteLine("Cool bro");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That's not an option, please do not try again.");
                Console.ReadLine();
            }

            return Series[FibNumber];
        }
    }
}

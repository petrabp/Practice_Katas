using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a Year to see if it will be a Leap Year");
            var Year = Int32.Parse(Console.ReadLine());

            if (Year % 2 != 0)
            {
                Console.WriteLine(false);
            }

            else if (Year % 100 == 0 && Year % 400 != 0)
            {
                Console.WriteLine(false);
            }
            else if (Year % 4 == 0)
            {
                Console.WriteLine(true);
            }
            Console.ReadLine();
        }   
    }
}
            


        
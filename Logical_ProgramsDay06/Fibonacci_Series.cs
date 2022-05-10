using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_ProgramsDay06
{
    public class Fibonacci_Series
    {
        public void FibonacciSeries()
        {
            int num, i;
            int present = 1;
            int previous = 0;
            int sum;
            Console.WriteLine("***Display the Fibonacci Series***");
            Console.Write("\n\n\n");

            //User Input
            Console.Write("Please Enter the Fibonacci number :");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fibonacci series of the enterd Number is {0} : ", num);
            Console.Write(" {0} {1}", previous, present);

            for (i = 2; i < num; i++)
            {
                sum = previous + present;
                Console.Write(" {0} ", sum);
                previous = present;
                present = sum;

            }
            Console.Write("\n");
        }

    }
}
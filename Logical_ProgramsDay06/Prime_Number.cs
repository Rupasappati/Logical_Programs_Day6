using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_ProgramsDay06
{
    public class Prime_Number
    {
    public void PrimeNum()
        {
            int num;
            int x=0;
            Console.Write("\n");
            Console.WriteLine("***Display the Prime Numbers***");
            Console.Write("\n");

            Console.WriteLine("Please Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < num/2; i++)
            {
                if(num % i == 0)
                {
                    x++;
                       
                }
            }
            if(x==0 && num != 0)
            {
                Console.WriteLine("{0} is Prime Number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", num);
            }
            Console.WriteLine("\n");
        }

    }
}

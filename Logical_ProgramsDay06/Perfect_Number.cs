using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_ProgramsDay06
{
    public class Perfect_Number
    {
        public void perfectNum()
        {
            
            int sum = 0;
            int num;

            Console.Write("\n");
            Console.WriteLine("***Find the Perfect Number***");
            Console.Write("\n");

            Console.WriteLine("Please Enter a Input :");
            num = Convert.ToInt32(Console.ReadLine());


            
            for (int i=1; i<= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    
                }
                
            }
            if (sum == num)
            {
                Console.Write("Number is perfect");
            }
            else
            {
                Console.WriteLine("Number is not perfect");
            }
            Console.WriteLine("\n");
        }
    }
}


    
    


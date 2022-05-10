using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_ProgramsDay06
{
    public class Reverse_a_Number
    {
        public void reverseNum()
        {
            int num,x,y;
            int sum = 0;
            Console.Write("\n");
            Console.WriteLine("***Display_Reverse a Number***");
            Console.Write("\n");

            Console.WriteLine("Enter a input: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (x = num; x!= 0; x = x/10)
            {
                y = x % 10;
                sum=sum*10+y;
            }
            Console.WriteLine("Number is in reverse order is : {0}", sum);
            Console.WriteLine("\n");
        }

    }

}

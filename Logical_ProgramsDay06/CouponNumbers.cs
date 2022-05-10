using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_ProgramsDay06
{
    public class CouponNumbers
    {
        public void Coupon()
        {
            int num;
            int coupon = 0;
            Console.Write("\n");
            Console.WriteLine("***Display the Coupon Numbers***");
            Console.Write("\n");

            Console.WriteLine("Enter the Coupon Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            string coupons = string.Empty;
            Random r = new Random();
            while (num > 0)
            {
                int random = r.Next(1, 123);
                coupon += random;
                num--;
            }

            Console.WriteLine("coupon is {0}", coupon);
            Console.WriteLine("\n");
        }
    }
}

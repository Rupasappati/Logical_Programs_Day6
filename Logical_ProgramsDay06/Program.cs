// See https://aka.ms/new-console-template for more information

namespace Logical_ProgramsDay06
{
    public class Program
    {
        static void Main(String[] args)

        {
            bool option = true;
            while (option == true)
            {
                Console.WriteLine("Which program would you like to excute ?");
                Console.WriteLine("Q1.Fibonacci Series");
                Console.WriteLine("Q2.Perfect Number");
                Console.WriteLine("Q3.Prime Number");
                Console.WriteLine("Q4.Reverse a Number");
                Console.WriteLine("Q5.Coupon Number");
                Console.WriteLine("Please enter the Question Number what you want to excute");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("You have choosen Q1");
                        Fibonacci_Series series = new Fibonacci_Series();
                        series.FibonacciSeries();
                        break;
                    case 2:
                        Console.WriteLine("You have choosen Q2");
                        Perfect_Number number = new Perfect_Number();
                        number.perfectNum();                      
                        break;
                    case 3:
                        Console.WriteLine("You have choosen Q3");
                        Prime_Number prime_Number = new Prime_Number();
                        prime_Number.PrimeNum();
                        break;
                    case 4:
                        Console.WriteLine("You have choosen Q4");
                        Reverse_a_Number reverse_a_Number = new Reverse_a_Number();
                        reverse_a_Number.reverseNum();
                        break;
                    case 5:
                        Console.WriteLine("You have choosen Q5");
                        CouponNumbers couponNumbers = new CouponNumbers();
                        couponNumbers.Coupon();
                        break;
                    default:
                        Console.WriteLine("Ivalid Input");
                        break;

                }
            }

        }
    }
}




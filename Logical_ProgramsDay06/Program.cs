// See https://aka.ms/new-console-template for more information

namespace Logical_Programs_Day6
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
                Console.WriteLine("Please enter the Question Number what you want to excute");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("You have choosen Q1");
                        Fibonacci_Series series = new Fibonacci_Series();
                        series.FibonacciSeries();
                        break;
                }
            }

        }
    }
}




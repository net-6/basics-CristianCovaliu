using System;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();

        }

        static void Sum()
        {
            Console.WriteLine("Please write first number:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Please write  second number:");
            string secondNumber = Console.ReadLine();

            Console.WriteLine("Please write  third number:");
            string thirdNumber = Console.ReadLine();

            int number1 = int.Parse(firstNumber);
            int number2 = int.Parse(secondNumber);
            int number3= int.Parse(thirdNumber);

            Console.WriteLine("The sum is: " + (number1 + number2 + number3));
        }
    }
}

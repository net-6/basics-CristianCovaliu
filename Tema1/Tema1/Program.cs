using System;
using System.Linq;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Problem1();
            //Problem2();
            //Problem3();
            //Problem4();
            //Problem5a();
            //Problem5b();
            //Problem6();
            //Problem7();
            //Problem8();
            //Problem9();
            //Problem10();
            //Problem11();
            //Problem12();
            //Problem13();
            //Problem14();
           
        }



        //1. Write a method that reads from the console three numbers of type int and prints their sum.
        static void Problem1()
        {
            Console.WriteLine("Please write first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write  second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write  third number:");
            int thirdNumber = int.Parse(Console.ReadLine());


            Console.WriteLine("The sum is: " + (firstNumber + secondNumber + thirdNumber));
        }



        //2. Write a method that reads five numbers from the console and prints the greatest of them.
        static void Problem2()
        {
            Console.WriteLine("Please write first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write third number:");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write forth number:");
            int forthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write fifth number:");
            int fifthNumber = int.Parse(Console.ReadLine());

            int[] numbers = { firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber };
            int greatestNumber = numbers.Max();

            Console.WriteLine("The greatest number is: " + greatestNumber);
        }



        //3. Write a method that reads from the console the radius "r" of a circle and prints its perimeter and area.
        static void Problem3()
        {
            Console.Write("r: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double perimeter = 2 * pi * radius;
            double area = pi * radius * radius;

            Console.WriteLine("The perimeter is: " + perimeter + " and the area is: " + area);

        }



        //4. Write a method that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5. 
        //such that the remainder of their division by 5 is 0.
        static void Problem4()
        {
            Console.WriteLine("Please write first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int numbers = 0;

            while (firstNumber < secondNumber)
            {
                firstNumber++;
                if (firstNumber % 5 == 0 & firstNumber < secondNumber)
                {
                    numbers++;
                }

            }
            while (firstNumber > secondNumber)
            {
                firstNumber--;
                if (firstNumber % 5 == 0 & firstNumber > secondNumber)
                {
                    numbers++;
                }

            }

            Console.WriteLine("We have " + numbers + " numbers divisible with 5");
        }



        //5. Write a method that reads two numbers from the console and prints the greater of them. 
        //Solve the problem without using conditional statements and with conditional statements.

        //without conditional statemets
        static void Problem5a()

        {
            Console.WriteLine("Please write first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int[] numbers = { firstNumber, secondNumber };
            int greatestNumber = numbers.Max();

            Console.WriteLine("The greatest number is: " + greatestNumber);
        }

        //with conditional statements
        static void Problem5b()
        {
            Console.WriteLine("Please write first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The greatest number is: " + firstNumber);
            }
            else
            {
                Console.WriteLine("The greatest number is: " + secondNumber);
            }

        }



        //6.Write a method that reads five integer numbers and prints their sum. 
        //If an invalid number is entered the method should prompt the user to enter another number(only once).
        static void Problem6()
        {
            static void ReadNumbers()
            {
                Console.WriteLine("Please write first number:");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please write second number:");
                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please write third number:");
                int thirdNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please write forth number:");
                int forthNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please write fifth number:");
                int fifthNumber = int.Parse(Console.ReadLine());

                int sum = firstNumber + secondNumber + thirdNumber + forthNumber + fifthNumber;
                Console.WriteLine("The sum is: " + sum);
            }
            try
            {
                ReadNumbers();
            }

            catch
            {
                Console.WriteLine("Invalid number. Please write another number:");
                ReadNumbers();
            }


        }




        //7. Write a method that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
        static void Problem7()
        {
            Console.WriteLine("Please enter your number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
                Console.WriteLine(i);
        }




        //8. Write a method that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. 
        //The number N should be read from the standard input.
        static void Problem8()
        {
            Console.WriteLine("Please enter your number:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 >= 1 & i % 7 >= 1)
                {
                    Console.WriteLine(i);
                }
            }
        }




        //9. Write a method that reads from the console a series of 5 integers and prints the smallest and largest of them.
        static void Problem9()
        {
            Console.WriteLine("Please write first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write third number:");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write forth number:");
            int forthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write fifth number:");
            int fifthNumber = int.Parse(Console.ReadLine());

            int[] numbers = { firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber };
            int greatestNumber = numbers.Max();
            int smallestNumber = numbers.Min();

            Console.WriteLine("The greatest number is: " + greatestNumber);
            Console.WriteLine("The smallest number is: " + smallestNumber);
        }



        //10. Write a method that outputs a triangle made of stars with variable size, depending on an input parameter. 
        //Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number. 
        //The output is a series of lines printed on the console, forming a triangle of variable size.
        static void Problem10()
        {
            static string PrintStars(int n)
            {
              
                for (int i = 0; i <= n; i++)
                {
                    Console.Write("*");
                }
                return "";
               
         
            }
            Console.WriteLine("Please enter your input:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(PrintStars(i));
            }
            for (int i = number; i >= 0; i--)
            {
                Console.WriteLine(PrintStars(i));
            }


        }



        //11. Write a method that converts a given number from decimal to binary notation (numeral system).
        static void Problem11()
        {
            Console.WriteLine("Please enter your number:");
            int number = int.Parse(Console.ReadLine());

            string response = string.Empty;
            while (number >= 1)
            {
                int remainder = number % 2;
                response = Convert.ToString(remainder) + response;
                number = number / 2;
                
            }
            Console.WriteLine("Binary:  {0}", response);

        }

        

        //12. Write a method that by a given integer N prints the numbers from 1 to N in random order.
        static void Problem12()
        {
            Random rnd = new Random();
            int temp;
            int randomNumber;

            Console.WriteLine("Please enter your input:");
            int number = int.Parse(Console.ReadLine());
            int[] list = new int[number];
            
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i;              
            }
            foreach (var i in list)
            {
                randomNumber = rnd.Next(0, number);
                temp = list[i];
                list[i] = list[randomNumber];
                list[randomNumber] = temp;
            }
            foreach (var i in list)
            {
                Console.Write(" " + list[i]);
            }            
        }



        //13. A method which iterates the integers from 1 to 50. For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
        //For numbers which are multiples of both three and five print "FizzBuzz".
        static void Problem13()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }



        //14. A given company has name, address, phone number, fax number, web site and manager. 
        //The manager has name, surname and phone number. 
        //Write a program that reads information about the company and its manager and then prints it on the console.

        static void Problem14()
        {
            Console.Write("Enter company name: ");
            string compName = Console.ReadLine();

            Console.Write("Enter company address: ");
            string compAddress = Console.ReadLine();

            Console.Write("Enter company phone number: ");
            string compPhone = Console.ReadLine();

            Console.Write("Enter fax number: ");
            string compFax = Console.ReadLine();

            Console.Write("Enter company website: ");
            string compSite = Console.ReadLine();

            Console.Write("Enter company manager name: ");
            string managerName = Console.ReadLine();

            Console.Write("Enter manager first name: ");
            string managerFName = Console.ReadLine();

            Console.Write("Enter manager last name: ");
            string managerLName = Console.ReadLine();

            Console.Write("Enter manager phone number: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Company| Name: {0}, Address: {1}, Phone number: {2}, Fax number: {3}, Website: {4}, Manager: {5}", compName, compAddress, compPhone, compFax, compSite, managerName);
            Console.WriteLine("Manager| Name: {0} {1}, Phone: {2}", managerFName, managerLName, managerPhone);

        }


    }
}




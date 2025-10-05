using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // If-Else Statement
            Console.Write("Enter the temperature: ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature < 35)
            {
                Console.WriteLine("It's a normal day");
                Console.WriteLine("Drink regular water");
            }
            else
            {
                Console.WriteLine("It's a hot day");
                Console.WriteLine("Drink cold water");
            }

            // If-Else If Statement
            if (temperature < 35)
            {
                Console.WriteLine("It's a normal day");
                Console.WriteLine("Drink regular water");
            }
            else if (temperature < 45)
            {
                Console.WriteLine("It's a hot day");
                Console.WriteLine("Drink plenty of water");
            }
            else
            {
                Console.WriteLine("Enjoy a great day");
            }

            // Switch Statement
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    Console.WriteLine("time able bellow");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    Console.WriteLine("time able bellow");
                    break;
                default:
                    Console.WriteLine("That number is not a day of the week");
                    break;
            }
        }
    }
}
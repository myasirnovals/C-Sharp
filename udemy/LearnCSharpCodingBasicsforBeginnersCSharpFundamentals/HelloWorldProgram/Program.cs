using System;

namespace HelloWorldProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Yan";
            string mobile = "1234567890";

            Console.WriteLine(name);
            Console.WriteLine(mobile);

            int myNum = 10;
            Console.WriteLine(myNum);

            double myDouble = 5.99D;
            char myLetter = 'D';
            bool myBool = true;

            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;

            Console.WriteLine("Hello " + fullName);

            int a = 10;
            int b = 20;
            int c = a + b;

            Console.WriteLine(c);
        }
    }
}
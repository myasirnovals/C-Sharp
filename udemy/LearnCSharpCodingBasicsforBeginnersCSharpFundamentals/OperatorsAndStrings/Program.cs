using System;

namespace OperatorsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aruthmetic Operators
            int total1 = 100 + 200;
            int total2 = total1 + 250;
            Console.WriteLine(total2);

            // Assignment Operators
            total1 += 100;
            total2 -= 50;
            Console.WriteLine(total1 + total2);

            // Comparison Operators
            
            // Logical Operators

            // String Operators
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName.ToUpper());
            
            // String Properties
            string txt = "Sample Text";
            Console.WriteLine(txt[0]);
            
            // Boolean Expressions
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine(isTrue && isFalse);
        }
    }
}
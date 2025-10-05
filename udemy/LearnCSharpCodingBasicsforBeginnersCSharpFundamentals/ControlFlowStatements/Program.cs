using System;

namespace myFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("While Loop: " + i);
                i++;
            }
            
            // Do While Loop
            i = 100;
            do
            {
                Console.WriteLine("Do While Loop: " + i);
                i++;
            } while (i < 10);
            
            // For Loop
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("For Loop: " + j);
            }
        }
    }
}
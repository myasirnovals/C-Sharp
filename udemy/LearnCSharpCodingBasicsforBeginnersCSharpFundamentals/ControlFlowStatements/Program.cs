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

            // For Each statement
            string[] travels = { "Car", "Bus", "Train", "Plane" };
            foreach (string travel in travels)
            {
                Console.WriteLine("For Each Loop: " + travel);
            }

            // break and continue
            for (int j = 0; j < 10; j++)
            {
                if (j % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine("For Loop: " + j);
                if (j == 5)
                {
                    break;
                }
            }
            
            // triangle star
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
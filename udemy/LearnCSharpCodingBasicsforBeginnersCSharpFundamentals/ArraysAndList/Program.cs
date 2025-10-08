using System;
using System.Collections.Generic;

namespace ArraysAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            string[] travels = { "Car", "Bus", "Plane" };
            int[] myNumbers = { 1, 2, 3, 4, 5 };

            travels[0] = "Train";

            Console.WriteLine(travels[0]);
            Console.WriteLine(myNumbers[0]);
            Console.WriteLine(travels.Length);

            // Loop through an array
            foreach (var travel in travels)
            {
                Console.WriteLine(travel);
            }

            // List
            var cities = new List<string>();

            // add a list
            cities.Add("Jakarta");
            cities.Add("Bandung");
            cities.Add("Surabaya");

            var country = new List<string>
            {
                "Indonesia", "Malaysia", "Singapore"
            };
        }
    }
}
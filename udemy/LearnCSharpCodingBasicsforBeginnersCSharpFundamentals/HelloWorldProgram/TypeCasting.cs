using System;

public class TypeCasting
{
    public void typeCastingExample()
    {
        string name = "Yan";

        // Implicit casting (automatically)
        // chart -> int -> long -> float -> double
        int myInt = 9;
        double myDouble = myInt; // int to double
        Console.WriteLine(myDouble); // Output: 9.0

        // Explicit casting (manually)
        // double -> float -> long -> int -> char
        double anotherDouble = 9.78;
        int myNewInt = (int)anotherDouble; // double to int
        Console.WriteLine(Convert.ToDecimal(myNewInt)); // Output: 9
    }
}


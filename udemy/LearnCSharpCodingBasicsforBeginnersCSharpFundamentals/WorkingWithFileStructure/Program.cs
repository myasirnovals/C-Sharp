using System;
using System.Collections.Generic;
using System.IO;

namespace WorkingWithFileStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // File and file information
            string writeText = "Hello World";
            File.WriteAllText("hello.txt", writeText);
        }
    }
}
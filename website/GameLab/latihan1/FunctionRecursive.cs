using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarRekursif
{
    class Program
    {      
        static void Main(string[] args)
        {
            recurs(0);
        }

        static void recurs(int x)
        {
            Console.WriteLine("RECURSIVE "+x);

            if (x < 5) // termination condition
            {
                recurs(x + 1); // fungsi recurs() memanggil dirinya sendiri (secara rekursif)

            }
        }
    }

}

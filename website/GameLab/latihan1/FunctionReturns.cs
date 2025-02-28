using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarFungsi
{
    class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine(beriNilai3());
            Console.WriteLine(hasilKali(2, 3));
        }

        static int beriNilai3()
        {
            // mengembalikan nilai integer 3.
            return 3;
        }

        // Fungsi ini membutuhkan dua parameter integer, yaitu x dan y.
        // Pada saat memanggil fungsi ini, 
        // harus menyertakan tambahan 2 paramater, untuk x dan untuk y.
        static int hasilKali(int x, int y)
        {
            // mengembalikan nilai integer dari hasil perkalian.
            // antara parameter x dengan parameter y.
            return x * y;
        }

    }

}

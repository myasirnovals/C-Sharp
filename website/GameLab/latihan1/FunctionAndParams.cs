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
            //3 adalah parameter yang dimasukkan untuk memanggil fungsi tampilkanSatu().
            tampilkanSatu(3);

            //5 dan 9 adalah parameter yang dimasukkan untuk memanggil fungsi tampilkanDua().
            tampilkanDua(5, 9);
        }

        // Fungsi ini membutuhkan satu parameter integer dengan nama x.
        // Pada saat memanggil fungsi ini, 
        // harus menyertakan tambahan satu paramater untuk x.
        static void tampilkanSatu(int x)
        {
            Console.WriteLine("Nilai x dalam fungsi tampilkanSatu: " + x);
        }

        // Fungsi ini membutuhkan dua parameter integer, 
        // yang pertama bernama x, dan yang kedua dengan nama y.
        // Pada saat memanggil fungsi ini, 
        // harus menyertakan tambahan dua paramater, untuk x dan untuk y.
        static void tampilkanDua(int x, int y)
        {
            Console.WriteLine("Nilai x dalam fungsi tampilkanSatu: " + x);
            Console.WriteLine("Nilai y dalam fungsi tampilkanSatu: " + y);
        }

    }

}

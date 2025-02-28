using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObejcts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(holiday.artist);
            Console.WriteLine(kashmir.artist);

            Console.WriteLine(Song.songCount);

            Console.ReadLine();
        }
    }
}

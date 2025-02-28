using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChiken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChiken();

            Console.ReadLine();
        }
    }
}

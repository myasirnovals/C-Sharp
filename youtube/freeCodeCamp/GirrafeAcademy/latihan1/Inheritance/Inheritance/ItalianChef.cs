using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Italian Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Italiang Chef makes chicken parm");
        }
    }
}

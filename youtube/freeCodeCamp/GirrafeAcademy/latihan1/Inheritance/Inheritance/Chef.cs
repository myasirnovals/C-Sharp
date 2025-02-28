using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Chef
    {
        public void MakeChiken()
        {
            Console.WriteLine("The Chef makes chiken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chek makes salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}

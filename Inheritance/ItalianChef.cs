using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ItalianChef : Chef
    {

        public override void MakeSpecialDish() //override
        {
            Console.WriteLine("The Chef makes chicken parm");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef makes Pasta");
        }
    }
}

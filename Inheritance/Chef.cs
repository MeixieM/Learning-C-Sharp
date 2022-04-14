using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }

        public virtual void MakeSpecialDish() //virtual means the method can be overwritten
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}

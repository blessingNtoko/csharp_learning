using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new();

            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new("Age of Ultron", "Joss Whedon", "PG-13");
            Movie shrek = new("Shrek 2", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);
        }
    }
}
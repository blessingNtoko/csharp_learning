using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new("The Deathly Hallows", "Rowling", 659);

            Book book2 = new("Fellowship of the Ring", "Tolkien", 750);

            // Console.WriteLine(book1.title);

            Student student1 = new Student("Bob", "Engineering", 3.4);
            Student student2 = new Student("Sarah", "Programming", 3.0);

            Console.WriteLine(student1.HasHonours());

        }
    }
}
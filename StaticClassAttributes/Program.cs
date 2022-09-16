using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song longaConversa = new("Longa Conversa", "Dj Danifox", 500);
            Console.WriteLine(Song.songCount);
            Song streets = new("Streets (Amapiano Remix)", "Loxiie Dee", 500);

            Console.WriteLine(streets.GetSongCount());
        }
    }
}
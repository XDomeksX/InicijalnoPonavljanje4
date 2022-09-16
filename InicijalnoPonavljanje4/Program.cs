using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ERROR1: Console.WriteLine("Unesite stranicu x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Stranica nemoze biti od 0 na manje.");
                goto ERROR1;
            }
            ERROR2: Console.WriteLine("Unesite stranicu y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("Stranica nemoze biti od 0 na manje.");
                goto ERROR2;
            }
            ERROR3: Console.WriteLine("Unesite stranicu z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            if (z == 0)
            {
                Console.WriteLine("Stranica nemoze biti od 0 na manje.");
                goto ERROR3;
            }

            if (Math.Pow(x, 2) + Math.Pow(y, 2) == z)
            {
                Console.WriteLine("Ovo su stranice pravokutnog trokuta.");
            }
            else
            {
                Console.WriteLine("Ovo nisu stranice pravokutnog trokuta.");
            }

            Console.ReadKey();
        }
    }
}

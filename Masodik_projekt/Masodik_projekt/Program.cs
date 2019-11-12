using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodik_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("1-től 100-ig azok a számok, amelyek valódi osztóinak az összege osztható 7-tel.");

            for (int i = 1; i < 101; i++)
            {
                if (osszeghettel(i))
                {
                    Console.WriteLine($"{i} valódi osztóinak összege osztható 7-tel");
                }
            }
            

            Console.ReadKey(true);*/

            Console.WriteLine("2-től 100-ig a prímszámokat: ");

            for (int i = 2; i < 101; i++)
            {
                if (primszamE(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey(true);
        }
        static bool osszeghettel(int szam)
        {
            int osszeg = 0;
            bool hettel = true;

            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }
            if  (osszeg % 7 != 0)
            {
                hettel = false;
            }

            return hettel;
        }
        static bool primszamE(int szam)
        {
            bool primE = true;
            int hatar = (int)Math.Floor(Math.Sqrt(szam)) + 1;

            for (int i = 2; i < hatar; i++)
            {
                if (szam % i == 0)
                {
                    primE = false;
                    break;
                }
            }

            return primE;
        }
    }
}

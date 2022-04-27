using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vind_Konverter
{
    internal class Tools
    {
        internal static string VælgVærdiAtKonventer()
        {
            string? ValgtVærdi;
            Console.WriteLine("Vælg den enhed som du ville konventer til en ny værdi");
            Console.WriteLine("1 - m/s \n2 - km/t \n3 - mph \n4 - knots");

            do
            {
                Console.WriteLine("vælg ved at indstaste et tal mellem 1 og 4");
                ValgtVærdi = Console.ReadKey().KeyChar.ToString();
            } while (ValgtVærdi != "1" && ValgtVærdi != "2" && ValgtVærdi != "3" && ValgtVærdi != "4");

            return (ValgtVærdi);

        }

        internal static string VælgVærdiKonvertersTil()
        {
            string? ValgtVærdi;
            Console.Clear();
            Console.WriteLine("Vælg den endhed som du ville konventer til");
            Console.WriteLine("1 - m/s \n2 - km/t \n3 - mph \n4 - knots");

            do
            {
                Console.WriteLine("vælg ved at indstaste et tal mellem 1 og 4");
                ValgtVærdi = Console.ReadKey().KeyChar.ToString();
            } while (ValgtVærdi != "1" && ValgtVærdi != "2" && ValgtVærdi != "3" && ValgtVærdi != "4");

            return (ValgtVærdi);

        }

        internal static double VælgVærdi()
        {
            double værdi;
            bool værdiSat = false;
            Console.Clear();
            Console.WriteLine("indtast værdi der skal konventeres");
            do
            {
                if (!double.TryParse(Console.ReadLine(), out værdi))
                {
                    Console.WriteLine("please intast nogle tal");
                }
                else
                {
                    værdiSat = true;
                }
            } while (værdiSat == false);

            return (værdi);
        }

        internal static void KonventerTing(string værdiKonventeres, string værdiKonventeresTil, double værdi)
        {
            double værdiTilMS= KonventerVærdiTilMS(værdi, værdiKonventeres);
            værdiTilMS = UdregnKonventering(værdiTilMS, værdiKonventeresTil);
            Console.WriteLine(værdiTilMS);

        }

        internal static double KonventerVærdiTilMS(double værdi , string værdiKonventeres)
        {
            if(værdiKonventeres == "2")
            {
                værdi = værdi*0.277777778;

            }
            if(værdiKonventeres == "3") 
            {
                værdi = værdi * 0.44704;
            }
            if (værdiKonventeres == "4")
            {
                værdi = værdi * 0.514444444;
            }
            return (værdi);
        }
        
        internal static double UdregnKonventering(double værdiTilMS, string værdiKonventeresTil) 
        {
            if (værdiKonventeresTil == "2")
            {
                værdiTilMS = værdiTilMS * 3.6;

            }
            if (værdiKonventeresTil == "3")
            {
                værdiTilMS = værdiTilMS * 2.23693629;
            }
            if (værdiKonventeresTil == "4")
            {
                værdiTilMS = værdiTilMS * 1.94384449;
            }
            return (værdiTilMS);

        }
    }
}

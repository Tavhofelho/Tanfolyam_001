using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            string szoveg = "szia";
            Console.WriteLine(szoveg);

            char karakter = 'k';
            Console.WriteLine(karakter);
            Console.WriteLine('c');
            char szokoz = ' ';
            Console.Write(szokoz);
            Console.WriteLine(karakter);

            int egeszSzam = 5; // változó létrehozás és értékadás
            Console.WriteLine(egeszSzam);
            int csakLetrehozom;
            csakLetrehozom = -9;
            Console.WriteLine(csakLetrehozom);

            uint elojelNelkuliEgesz = 8;
            //uint elojel = -5;

            /* 
            ez egy blokk komment (több soros)
            */

            Console.WriteLine(int.MaxValue);

            long nagyobbEgesz = 15L;
            //int nagyszam = 11111111111111; // túl nagy
            long nagySzam = 11111111111111;
            ulong elojelNelkuliNagy = 1322545;

            byte egyByta = 7; // sbyte
            short kisSzam = 4321; // ushort

            //lebegőpontos számtípusok
            double tortSzam = 1.51; //Tízedes pont lesz, mert andol a programozási nyelv
            Console.WriteLine(tortSzam);
            float nemAnnyiraPontosTortSzam = 1.5F;

            decimal pontosTortSzam = 1.5M;

            //Műveletek számokkal
            int a = 7;
            int b = 2;
            int osszeg = a + b;
            Console.WriteLine(osszeg);

            int kulonbseg = a-b;
            int szorzat = a * b;

            Console.WriteLine( a / b); //Osztás, csak az egész számot adja vissza

            int maradek = a % b;
            Console.WriteLine( maradek); //Maradékos osztás, mert int/int -> 7/2=3

            Console.WriteLine(7 / 2);
            Console.WriteLine(7 / 2.0);
            Console.WriteLine(7 / 2D); // 7et elosztjuk 2vel és a 2 double típus
            Console.WriteLine(7 / (double)b); //cast - kasztolás

            long implicitCast = 5; //Automatikus konverzió

            //BITMŰVELETEK: |, &, ^, ~


            //bool - csak IGAZ vagy HAMIS
            bool logikaiTípus = true;
            bool hamis = false;
            Console.WriteLine(logikaiTípus);

            //logikai operátorok
            Console.WriteLine(3 + 5 == 8);
            Console.WriteLine(a != 7); //nem egyenlő
            Console.WriteLine(3 >= 5); //nagyobb vagy egyenlő

            bool igaz = !hamis; //negálás
            Console.WriteLine(igaz);

            double d1 = 100000000000000;
            double diff = 0.0000000001D;
            double d2 = d1;
            Console.WriteLine(d1 + diff > d2);

            //konstansok - globálisan meghatározott érték, amit csak egy helyen kell átírni
            const int konstans = 6;
            Console.WriteLine(konstans);
            const int konstans2 = 45632 * 6 + 54645;
            //const int konstans3 = egeszSzam; //HIBA
            //konstans2 = konstans2 + 5; //HIBA

            const string konstansSzoveg = "hello";
            Console.WriteLine(konstansSzoveg);

            Console.Clear();

            //Vezérlési szerkezetek
            Console.Write("Kérlek adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());  //Parse - átalakítja a szöveget int formátummá
            Console.WriteLine(szam);

            //Függvények
            if (szam % 2 == 0)
            {
                Console.WriteLine("Páros");
            }
            else
            {
                Console.WriteLine("Páratlan");
            }

            int mar = szam % 3;
            if (mar == 0)
            {
                Console.WriteLine("0-at ad");
            }
            else if (mar == 1)
            {
                Console.WriteLine("1-et ad");
            }
            else //if (mar == 2)
            {
                Console.WriteLine("2-őt ad");
            }

            switch(mar)
            {
                case 0: //if (mar == 0)
                    Console.WriteLine("0-at ad");
                    break;
                case 1:
                    Console.WriteLine("1-et ad");
                    break;
                case 2:
                    Console.WriteLine("2-őt ad");
                    break;
                default:
                    Console.WriteLine("Egyéb");
                    break;
            }

            string parosE = szam % 2 == 0 ? "Igen" : "Nem";
            /*
            if (szam % 2 == 0)
            {
                parosE  "Igen";
            }
            else
            {
                parosE = "Nem";
            }
            */

            int parosEInteger = szam % 2 == 0 ? 5 : 7;

            //Ciklusok
            
            for (int j=1; j<= szam; j++)
            {
                if (szam % j == 0)
                {
                    Console.WriteLine("Osztó: ", j);
                }
            }

            Console.ReadKey();

            
        }
    }
}

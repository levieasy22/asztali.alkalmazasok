using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program2
    {
        // Existing methods (F1 to F14) from the previous response remain here...

        static void F15()
        {
            Console.WriteLine("beolvas egy pozitív egész számot, és kiírja az egész számokat a képernyőre eddig a számig, egyenlőtlenekkel elválasztva!");
            Console.Write("Kérlek, adj meg egy pozitív számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i < n) Console.Write(" != ");
            }
            Console.WriteLine();
        }

        static void F16()
        {
            Console.WriteLine("beolvas egy pozitív egész számot, és kiírja az egész számokat egyenlőtlennel a képernyőre eddig a számig!");
            Console.Write("Kérlek, adj meg egy pozitív számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " != " + (i + 1));
            }
        }

        static void F17()
        {
            Console.WriteLine("beolvas egy pozitív egész számot, és kiírja az osztóit!");
            Console.Write("Kérlek, adj meg egy pozitív számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) Console.WriteLine(i);
            }
        }

        static void F18()
        {
            Console.WriteLine("beolvas egy pozitív egész számot, és kiírja az osztoinak az összegét!");
            Console.Write("Kérlek, adj meg egy pozitív számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int osszeg = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) osszeg += i;
            }
            Console.WriteLine($"Az osztoik összege: {osszeg}");
        }

        static void F19()
        {
            Console.WriteLine("beolvas egy pozitív egész számot, és megmondja, hogy tökéletes szám-e!");
            Console.Write("Kérlek, adj meg egy pozitív számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int osszeg = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) osszeg += i;
            }
            if (osszeg == n) Console.WriteLine("Tökéletes szám!");
            else Console.WriteLine("Nem jó szám!");
        }

        static void F20()
        {
            Console.WriteLine("beolvassa a hatvány alapját és a kitevőt, és kiírja a hatványértéket!");
            Console.Write("Kérlek, add meg az alapot: ");
            int alap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, add meg a kitevőt: ");
            int kitevo = Convert.ToInt32(Console.ReadLine());
            int eredmeny = 1;
            for (int i = 0; i < kitevo; i++)
            {
                eredmeny *= alap;
            }
            Console.WriteLine($"A hatvány értéke: {eredmeny}");
        }

        static void F21()
        {
            Console.WriteLine("pozitív szám");
            Console.Write("Kérlek, adj meg egy pozitív számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                Console.WriteLine(n);
                n--;
            }
        }

        static void F22()
        {
            Console.WriteLine("olvas be számokat a billentyűzetről, ameddig azok kisebbek, mint tíz.");
            int osszeg = 0;
            while (true)
            {
                Console.Write("Kérlek, adj meg egy számot");
                int szam = Convert.ToInt32(Console.ReadLine());
                if (szam >= 10) break;
                osszeg += szam;
            }
            Console.WriteLine($"A beolvasott számok összege: {osszeg}");
        }

        static void F23()
        {
            Console.WriteLine("beolvas egy egész számot, majd eloszja 2-vel annyiszor, amenyit lehet!");
            Console.Write("Kérlek, adj meg egy számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int eredmeny = n;
            int oszto = 0;
            while (eredmeny % 2 == 0)
            {
                eredmeny /= 2;
                oszto++;
            }
            Console.WriteLine($"Eredmény: {eredmeny}, osztható {oszto} alkalommal 2-vel.");
        }

        static void F24()
        {
            Console.WriteLine("24-es feladat");
            Console.Write("Kérlek, adj meg egy szót: ");
            string szo = Console.ReadLine();
            if (szo == "alma") Console.WriteLine("Az alma gyümölcs!");
        }

        static void F25()
        {
            Console.WriteLine("beolvas egy egész számot, majd addig von ki belőle 3-at, amíg harmónál kisebb nem lesz az eredmény.");
            Console.Write("Kérlek, adj meg egy számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n >= 3)
            {
                n -= 3;
            }
            Console.WriteLine($"Maradék: {n}");
        }

        static void F26()
        {
            Console.WriteLine("eldönti egy számról, hogy prímszám-e.");
            Console.Write("Kérlek, adj meg egy számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool prim = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) prim = false;
            }
            if (prim && n > 1) Console.WriteLine("Prímszám!");
            else Console.WriteLine("Nem prímszám!");
        }

        static void F27()
        {
            Console.WriteLine("beolvas egy számot, és kiírja a prímszámokat eddig a számig!");
            Console.Write("Kérlek, adj meg egy számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool prim = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) prim = false;
                }
                if (prim) Console.WriteLine(i);
            }
        }

        static void F28()
        {
            Console.WriteLine("beolvas egy számot, és kiírja a szám prímosztóit!");
            Console.Write("Kérlek, adj meg egy számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i);
                    n /= i;
                }
            }
        }

        static void F29()
        {
            Console.WriteLine("beolvas egy számot, majd kiírja a szám prímtényezős felbontását!");
            Console.Write("Kérlek, adj meg egy számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " * ");
                    n /= i;
                }
            }
            Console.WriteLine("1");
        }

        static void F30()
        {
            Console.WriteLine("beolvas két számot, és kiírja a két szám legnagyobbb közös osztóját!");
            Console.Write("Kérlek, adj meg az első számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, adj meg a második számot: ");
            int b = Convert.ToInt32(Console.ReadLine());
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine($"A legnagyobb közös osztó: {a}");
        }

        static void F31()
        {
            Console.WriteLine("beolvas két számot, és kiírja a legkisebb közös többszörösüket!");
            Console.Write("Kérlek, adj meg az első számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, adj meg a második számot: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int lcm = (a * b) / F30Helper(a, b); // Using F30's GCD logic
            Console.WriteLine($"A legkisebb közös többszörös: {lcm}");
        }

        static int F30Helper(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Válassz egy feladatot (15-31): ");
            int valasztas = Convert.ToInt32(Console.ReadLine());

            switch (valasztas)
            {
                case 15: F15(); break;
                case 16: F16(); break;
                case 17: F17(); break;
                case 18: F18(); break;
                case 19: F19(); break;
                case 20: F20(); break;
                case 21: F21(); break;
                case 22: F22(); break;
                case 23: F23(); break;
                case 24: F24(); break;
                case 25: F25(); break;
                case 26: F26(); break;
                case 27: F27(); break;
                case 28: F28(); break;
                case 29: F29(); break;
                case 30: F30(); break;
                case 31: F31(); break;
                default: Console.WriteLine("Érvénytelen választás!"); break;
            }
        }
    }
}

using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello world!");
        }

        static void F2()
        {
            Console.WriteLine("beolvassa a felhasználó nevét, majd köszön neki!");
            Console.Write("Kérlek, add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}!");
        }

        static void F3()
        {
            Console.WriteLine("beolvas egy számot, majd kiírja a kétszeresét!");
            Console.Write("Kérlek, adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A kétszerese: {szam * 2}");
        }

        static void F4()
        {
            Console.Write("Kérlek, adj meg egy számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, adj meg egy másik számot: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Összeg: {a + b}");

            Console.WriteLine("b. különbségüket;");
            Console.WriteLine($"Különbség: {a - b}");

            Console.WriteLine("c. szorzatukat;");
            Console.WriteLine($"Szorzat: {a * b}");

            Console.WriteLine("d. hányadosukat, ha lehet!");
            if (b != 0)
                Console.WriteLine($"Hányados: {(double)a / b}");
            else
                Console.WriteLine("Nem lehet osztani nullával!");
        }

        static void F5()
        {
            Console.WriteLine("beolvas két egész számot, és kiírja a képernyőre a nagyobbikat!");
            Console.Write("Kérlek, adj meg egy számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, adj meg egy másik számot: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine($"A nagyobbik: {a}");
            else
                Console.WriteLine($"A nagyobbik: {b}");
        }

        static void F6()
        {
            Console.WriteLine("beolvas három egész számot, és kiírja a képernyőre a legkisebbet!");
            Console.Write("Kérlek, adj meg egy számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, adj meg egy másik számot: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, adj meg egy harmadik számot: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a <= b && a <= c)
                Console.WriteLine($"A legkisebb: {a}");
            else if (b <= a && b <= c)
                Console.WriteLine($"A legkisebb: {b}");
            else
                Console.WriteLine($"A legkisebb: {c}");
        }

        static void F7()
        {
            Console.WriteLine("beolvassa a harmonszög oldalainak hosszát, és megmondja, hogy ilyen oldalhosszakkal szerkeszthető-e háromszög!");
            Console.Write("Kérlek, add meg az első oldalt: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, add meg a második oldalt: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, add meg a harmadik oldalt: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && b + c > a && a + c > b)
                Console.WriteLine("Ilyen oldalhosszakkal szerkeszthető háromszög!");
            else
                Console.WriteLine("Ilyen oldalhosszakkal nem szerkeszthető háromszög!");
        }

        static void F8()
        {
            Console.WriteLine("beolvas két pozitív egész számot, és kiírja a számítás eredményét!");
            Console.Write("Kérlek, adj meg egy pozitív számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérlek, adj meg egy másik pozitív számot: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0)
            {
                double gyokA = Math.Sqrt(a);
                double gyokB = Math.Sqrt(b);
                Console.WriteLine($"A gyök {a}-ból: {gyokA}");
                Console.WriteLine($"A gyök {b}-ból: {gyokB}");
            }
            else
                Console.WriteLine("Kérlek, csak pozitív számokat adj meg!");
        }

        static void F9()
        {
            Console.WriteLine("beolvassa a másodfokú egyenlet együtthatóit, és kiírja, hogy az egyenletnek van-e megoldása!");
            Console.Write("Kérlek, add meg az a együtthatót: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérlek, add meg a b együtthatót: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérlek, add meg a c együtthatót: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double diszkriminans = b * b - 4 * a * c;
            if (diszkriminans > 0)
                Console.WriteLine("Van két valós megoldása!");
            else if (diszkriminans == 0)
                Console.WriteLine("Van egy valós megoldása!");
            else
                Console.WriteLine("Nincs valós megoldása!");
        }

        static void F10()
        {
            Console.WriteLine("beolvassa a másodfokú egyenlet együtthatóit, és kiírja az egyenlet megoldásait, ha vannak!");
            Console.Write("Kérlek, add meg az a együtthatót: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérlek, add meg a b együtthatót: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérlek, add meg a c együtthatót: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double diszkriminans = b * b - 4 * a * c;
            if (diszkriminans > 0)
            {
                double x1 = (-b + Math.Sqrt(diszkriminans)) / (2 * a);
                double x2 = (-b - Math.Sqrt(diszkriminans)) / (2 * a);
                Console.WriteLine($"Az egyenlet megoldásai: x1 = {x1}, x2 = {x2}");
            }
            else if (diszkriminans == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Az egyenlet megoldása: x = {x}");
            }
            else
                Console.WriteLine("Nincs valós megoldása!");
        }

        static void F11()
        {
            Console.WriteLine("beolvassa egy derékszögű háromszög két befogóját, és megadja az átfogóját!");
            Console.Write("Kérlek, add meg az első befogót: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérlek, add meg a második befogót: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double atfogó = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Az átfogó hossza: {atfogó}");
        }

        static void F12()
        {
            Console.WriteLine("beolvassa a téglatest három élének hosszát, és kiírja a felszínét és térfogatát!");
            Console.Write("Kérlek, add meg az első élt: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérlek, add meg a második élt: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérlek, add meg a harmadik élt: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double felszin = 2 * (a * b + b * c + a * c);
            double terfogat = a * b * c;
            Console.WriteLine($"Felszín: {felszin}");
            Console.WriteLine($"Térfogat: {terfogat}");
        }

        static void F13()
        {
            Console.WriteLine("beolvassa egy kör átmérőjét, és kiírja a kör kerületét és területét!");
            Console.Write("Kérlek, add meg a kör átmérőjét: ");
            double atmero = Convert.ToDouble(Console.ReadLine());
            double kerulet = atmero * Math.PI;
            double terulet = Math.PI * (atmero / 2) * (atmero / 2);
            Console.WriteLine($"Kerület: {kerulet}");
            Console.WriteLine($"Terület: {terulet}");
        }

        static void F14()
        {
            Console.WriteLine("beolvassa a körív sugarát és középponti szögét, és kiírja a körív terelétét és a határoló ív hosszát!");
            Console.Write("Kérlek, add meg a sugarat: ");
            double sugar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérlek, add meg a középponti szöget: ");
            double szog = Convert.ToDouble(Console.ReadLine());
            double terulet = (szog / 360) * Math.PI * sugar * sugar;
            double ivhossz = (szog / 360) * 2 * Math.PI * sugar;
            Console.WriteLine($"Terület: {terulet}");
            Console.WriteLine($"Ív hossza: {ivhossz}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Válassz egy feladatot (1-14): ");
            int valasztas = Convert.ToInt32(Console.ReadLine());

            switch (valasztas)
            {
                case 1:
                    F1();
                    break;
                case 2:
                    F2();
                    break;
                case 3:
                    F3();
                    break;
                case 4:
                    F4();
                    break;
                case 5:
                    F5();
                    break;
                case 6:
                    F6();
                    break;
                case 7:
                    F7();
                    break;
                case 8:
                    F8();
                    break;
                case 9:
                    F9();
                    break;
                case 10:
                    F10();
                    break;
                case 11:
                    F11();
                    break;
                case 12:
                    F12();
                    break;
                case 13:
                    F13();
                    break;
                case 14:
                    F14();
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás!");
                    break;
            }
        }
    }
}

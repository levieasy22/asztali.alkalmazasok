using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
            Console.Clear();

            //2. feladat
            Console.WriteLine("Add meg a neved");
            string name = Console.ReadLine();
            Console.WriteLine($"Szia {name}");
            Console.ReadLine();
            Console.Clear();

            //3. feladat
            Console.WriteLine("Adj meg egy számot");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"A szám szorzata: {number * 2}");
            Console.ReadLine();
            Console.Clear();

            //4. feladat
            Console.WriteLine("Adj meg egy számot");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik számot");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Összegük: {number1 + number2}");
            if (number1 > number2)
            {
                Console.WriteLine($"Különbségük: {number1 - number2}");
            }
            else
            {
                Console.WriteLine($"Különbségük: {number2 - number1}");
            }
            Console.WriteLine($"Szorzatuk {number1 * number2}");
            Console.WriteLine($"Hányadosuk {number1 % number2}");
            Console.ReadLine();
            Console.Clear();

            //5. feladat
            Console.WriteLine("Adj meg egy számot");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik számot");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"A nagyobbik szám: {num1}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {num2}");
            }
            Console.ReadLine();
            Console.Clear();

            //6. feladat
            Console.WriteLine("Adj meg egy számot");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik számot");
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy harmadik számot");
            int szam3 = int.Parse(Console.ReadLine());
            if (szam1 < szam2)
            {
                Console.WriteLine($"A legkisebb szám a 3 közül {szam1}");
            }

            else if (szam3 < szam1)
            {
                Console.WriteLine($"A legkisebb szám a 3 közül {szam3}");
            }

            else
            {
                Console.WriteLine($"A legkisebb szám a 3 közül {szam2}");
            }
            Console.ReadLine();
            Console.Clear();

            //7. feladat
            Console.WriteLine("Add meg a háromszög egyik oldalát");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a háromszög második oldalát");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a háromszög harmadik oldalát");
            int c = int.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.Clear();

            //8. feladat
            Console.WriteLine("Adj meg egy pozitív egész számot");
            uint szamtani1 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy újabb pozitív egész számot");
            uint szamtani2 = uint.Parse(Console.ReadLine());
            Console.WriteLine($"A két szám számtani közepe: {(szamtani1 + szamtani2) / 2}");
            Console.ReadLine();
            Console.Clear();

            //9. feladat
            Console.WriteLine("Írd le az első együtthatót");
            int egyutthato1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd le a második együtthatót");
            int egyutthato2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd le a második együtthatót");
            int egyutthato3 = int.Parse(Console.ReadLine());

            int D = egyutthato2 * egyutthato2 - 4 * egyutthato1 * egyutthato3;
            if (D >= 0)
            {
                Console.WriteLine("Van valós megoldás");
            }
            else
            {
                Console.WriteLine("Nincs valós megoldás");
            }
            Console.ReadLine();
            Console.Clear();

            //10. feladat
            Console.WriteLine("Írd le az első együtthatót");
            int ehato1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd le a második együtthatót");
            int ehato2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd le a második együtthatót");
            int ehato3 = int.Parse(Console.ReadLine());

            int Disz = egyutthato2 * egyutthato2 - 4 * egyutthato1 * egyutthato3;
            if (Disz >= 0)
            {
                Console.WriteLine($"A megoldása: {Math.Sqrt(Disz)}");
            }
            else
            {
                Console.WriteLine("Nincs megoldás");
            }
            Console.ReadLine();
            Console.Clear();

            //11. feladat
            Console.WriteLine("Add meg a háromszög egyik befogóját");
            double ha = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a háromszög másik befogóját");
            int hb = int.Parse(Console.ReadLine());
            double atfogo = Math.Sqrt(ha * ha + hb * hb);
            Console.WriteLine($"Az átfogó hossza: {atfogo:F2}");
            Console.ReadLine();
            Console.Clear();

            //12. feladat
            Console.WriteLine("Add meg a téglalap egyik élének hosszát");
            int ta = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a téglalap másik élének hosszát");
            int tb = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a téglalap harmadik élének hosszát");
            int tc = int.Parse(Console.ReadLine());
            int felszin = 2 * (ta * tb + ta * tc + tb * tc);
            Console.WriteLine($"A téglatest felszíne: {felszin}");
            int terfogat = ta * tb * tc;
            Console.WriteLine($"A téglatest térfogata: {terfogat}");
            Console.ReadLine();
            Console.Clear();

            //13. feladat
            Console.WriteLine("Add meg a kör átmerőjét");
            int koratmero = int.Parse(Console.ReadLine());
            int kerulet = koratmero * (int)Math.PI;
            Console.WriteLine($"Kör kerülete: {kerulet}");
            int sugar = koratmero / 2;
            int terulet = (int)Math.PI * sugar * sugar;
            Console.WriteLine($"Kör területe: {terulet}");
            Console.ReadLine();
            Console.Clear();

            //14. feladat
            Console.WriteLine("Add meg a körív sugarát");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a körív középponti szögét");
            int o = int.Parse(Console.ReadLine());
            int korcikkiv = o/360 * (2 * r) * (int)Math.PI;
            int korcikkterulet = o/360 * (r * r) * (int)Math.PI;
            Console.WriteLine($"A körív területe: {korcikkiv}");
            Console.WriteLine($"A körív határoló ív hossza: {korcikkterulet}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

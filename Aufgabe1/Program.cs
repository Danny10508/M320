using System;

namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = ReadInt();
            int b = ReadInt();
            var result = MyMath.Calc_Ggt(a, b);
            Console.WriteLine($"Resultat: {result}");
        }

        static int ReadInt()
        {
            while (true)
            {
                Console.Write("Bitte Zahl eingeben: ");
                string s = Console.ReadLine();
                int zahl = int.Parse(s);
                {
                    return zahl;
                }
               
            }
        }
    }


    public static class MyMath
    {
        public static int Calc_Ggt(int a, int b)
        {
            int z;

            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }

            return a;
        }
    }
}
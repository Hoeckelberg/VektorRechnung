using System;
using System.Numerics;

namespace Vektorrechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            Vektor V1 = new Vektor(1, 2, 3);
            Vektor V2 = new Vektor(4, 5, 6);
            Vektor V4 = new Vektor();

            Console.WriteLine("\nVektor 1 X: " + V1.X + "\n");
            Console.WriteLine("Vektor 1 Y: " + V1.Y + "\n");
            Console.WriteLine("Vektor 1 Z: " + V1.Z + "\n");
            Console.WriteLine("----------------------------");
            Console.WriteLine("\nVektor 2 X: " + V2.X + "\n");
            Console.WriteLine("Vektor 2 Y: " + V2.Y + "\n");
            Console.WriteLine("Vektor 3 Z: " + V2.Z + "\n");

            Vektor V3 = V1.Addieren(V2);
            V3.Ausgeben();
            Console.WriteLine("Vektor 3 Laenge: " + V3.Betrag());
            V3.Einheitsvektor();
            V4.Winkel2Vektoren();
            Console.ReadKey();
        }
    }
}

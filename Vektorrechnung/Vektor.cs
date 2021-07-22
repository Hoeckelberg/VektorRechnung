using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics;
using System.Text;

namespace Vektorrechnung
{
    class Vektor
    {
        private double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        private double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public Vektor()
        {

        }
        public Vektor(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double Betrag()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }
        public Vektor Addieren(Vektor w)
        {
            Vektor V = new Vektor();
            V.x = this.x + w.x;
            V.y = this.y + w.y;
            V.z = this.z + w.z;
            return V;

            //return new Vektor(v.x + w.x, v.z + w.z, v.z + w.z);
        }
        public Vektor Subtrahieren(Vektor w)
        {
            Vektor V = new Vektor();
            V.x = this.x - w.x;
            V.y = this.y - w.y;
            V.z = this.z - w.z;
            return V;
        }
        public double Skalarprodukt(Vektor w)
        {
            double nx = w.x * x;
            double ny = w.y * y;
            double nz = w.z * z;
            return nx + ny + nz;
        }
        public double Winkel2Vektoren()
        {
            Vektor V = new Vektor(1, -3, 2);
            Vektor W = new Vektor(-2, 6, 4);

            double Vb = V.Betrag();
            double Wb = W.Betrag();

            double nx = V.x * W.x;
            double ny = V.y * W.y;
            double nz = V.z * W.z;
            double erg = nx + ny + nz;
            Console.WriteLine(erg / (Vb * Wb));
            return (erg / (Vb * Wb));
        }
        public Vektor Einheitsvektor()
        {
            Console.WriteLine("\n--------------Einheitsvektor------------\n");
            Vektor V = new Vektor();
            V.x = this.x;
            V.y = this.y;
            V.z = this.z;

            double Vb = (1 / V.Betrag());
            double nx = V.x * Vb;
            double ny = V.y * Vb;
            double nz = V.z * Vb;

            Console.WriteLine("x: " + nx);
            Console.WriteLine("y: " + ny);
            Console.WriteLine("z: " + nz);
            Console.WriteLine("\n----------------------------- \n");
            return V;
        }
        public void Ausgeben()
        {
            Console.WriteLine("\n--- Vektor 1 + Vektor 2 ---\n");
            Console.WriteLine("x: " + x, "\n");
            Console.WriteLine("y: " + y, "\n");
            Console.WriteLine("z: " + z, "\n");
            Console.WriteLine("\n----------------\n");
        }
    }
}

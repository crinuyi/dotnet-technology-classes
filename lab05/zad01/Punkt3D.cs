using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Punkt3D : Punkt {
        private double z;
        public Punkt3D(double x, double y, double z) : base(x, y) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public new void Wypisz() {
            Console.WriteLine($"({x}, {y}, {z})");
        }

        public new double Oblicz() {
            Console.WriteLine("Odległość punktu od początku układu współrzędnych:");
            double odleglosc = Math.Sqrt((x * x) + (y * y) + (z * z));
            Console.WriteLine(odleglosc);
            Console.WriteLine();
            return odleglosc;
        }

        public double Oblicz(Punkt3D punkt) {
            Console.WriteLine("Odległość punktu " + $"({x}, {y}, {z})" + " od punktu " + $"({punkt.x}, {punkt.y}, {punkt.z})" + ':');
            double odleglosc = Math.Sqrt((punkt.x * x) + (punkt.y * y) + (punkt.z * z));
            Console.WriteLine(odleglosc);
            Console.WriteLine();
            return odleglosc;
        }

        public Boolean CzyTrojkat(Punkt3D p2, Punkt3D p3) {
            return base.CzyTrojkat((Punkt)p2, (Punkt)p3);
        }
    }
}

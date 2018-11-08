using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Punkt {
        protected double x;
        protected double y;

        public Punkt(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public void Wypisz() {
            Console.WriteLine($"({x}, {y})");
        }

        public double Oblicz() {
            Console.WriteLine("Odległość punktu od początku układu współrzędnych:");
            double odleglosc = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine(odleglosc);
            Console.WriteLine();
            return odleglosc;
        }

        public double Oblicz(Punkt punkt) {
            Console.WriteLine("Odległość punktu " + $"({x}, {y})" + " od punktu " + $"({punkt.x}, {punkt.y})" + ':');
            double odleglosc = Math.Sqrt((punkt.x * x) + (punkt.y * y));
            Console.WriteLine(odleglosc);
            Console.WriteLine();
            return odleglosc;
        }

        public Boolean CzyTrojkat(Punkt p2, Punkt p3) {
            double ab = Oblicz(p2);
            double ac = Oblicz(p3);
            double bc = p2.Oblicz(p3);

            if (ab < (ac + bc))
                return true;
            else if (ac < (ab + bc))
                return true;
            else if (bc < (ac + ab))
                return true;
            else return false;
        }
    }
}

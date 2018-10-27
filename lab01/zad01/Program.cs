using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Punkt {
        public double x = 0, y = 0;

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

    class Program {
        static void Main(string[] args) {
            Punkt p1 = new Punkt();
            Punkt p2 = new Punkt();
            Punkt p3 = new Punkt();

            p1.x = 3;
            p1.y = 4;
            p2.x = 10;
            p2.y = 20;
            p3.x = 15;
            p3.y = 8;

            p1.Wypisz();
            p2.Wypisz();

            p1.Oblicz();
            p2.Oblicz();
            p1.Oblicz(p2);
            p2.Oblicz(p1);

            if (p1.CzyTrojkat(p2, p3))
                Console.WriteLine("Z punktów można utworzyć trójkąt.");
            else Console.WriteLine("Z punktów nie można utworzyć trójkąt.");
        }
    }
}

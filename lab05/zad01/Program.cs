using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Program {
        static void Main(string[] args) {
            Punkt3D point = new Punkt3D(1, 2, 3);
            Punkt3D point2 = new Punkt3D(4, 5, 6);
            Punkt3D point3 = new Punkt3D(7, 8, 9);
            point.Wypisz();
            point.Oblicz();
            point.Oblicz(point2);
            if (point.CzyTrojkat(point2, point3))
                Console.WriteLine("Z podanych punktów można utworzyć trójkąt.");
        }
    }
}

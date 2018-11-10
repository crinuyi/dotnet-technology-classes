using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Program {
        static void Main(string[] args) {
            LineSegment line = new LineSegment("linia", 1, 2, 6, 8);
            Console.WriteLine(line.Info());

            Disk disk = new Disk("koło", 5, 8, 14);
            Console.WriteLine(disk.Info());

            Square square = new Square("kwadrat", 0, 0, 2, 0, 2, 2, 0, 2);
            Console.WriteLine(square.Info());

            Triangle triangle = new Triangle("trójkąt", 0, 0, 4, 3, 8, 15);
            Console.WriteLine(triangle.Info());
        }
    }
}

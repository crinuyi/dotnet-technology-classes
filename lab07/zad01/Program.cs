using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Program {
        static void Main(string[] args) {
            Coordinate[] lineCoordinates = new Coordinate[2];
            lineCoordinates[0] = new Coordinate(1, 2);
            lineCoordinates[1] = new Coordinate(6, 8);
            LineSegment line = new LineSegment("linia", lineCoordinates);
            Console.WriteLine(line.Info());

            Disk disk = new Disk("koło", 5, 8, 14);
            Console.WriteLine(disk.Info());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class LineSegment : GeometricalFigure {
        private Coordinate[] coordinates = new Coordinate[2];

        public LineSegment(string name, int x1, int y1, int x2, int y2) {
            this.name = name;
            coordinate[0] = new Coordinate(x1, y1);
            coordinate[1] = new Coordinate(x2, y2);
        }

        public override string Info() {
            return "\n\t Nazwa: " + name +
                   "\n\t Długość: " + coordinate[0].Length(coordinate[1]) +
                   "\n\t Współrzędne: (" + coordinate[0].getX() + ", " + coordinate[0].getY() + "); (" +
                   coordinate[1].getX() + ", " + coordinate[1].getY() + ")";
        }
    }
}

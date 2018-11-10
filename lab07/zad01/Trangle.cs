using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Triangle : GeometricalFigure, ICalculations {
        private new Coordinate[] coordinate = new Coordinate[3];

        public Triangle(string name, int x1, int y1, int x2, int y2, int x3, int y3) {
            this.name = name;
            coordinate[0] = new Coordinate(x1, y1);
            coordinate[1] = new Coordinate(x2, y2);
            coordinate[2] = new Coordinate(x3, y3);
        }

        public double Circuit() {
            return coordinate[0].Length(coordinate[1]) +
                coordinate[1].Length(coordinate[2]) +
                coordinate[2].Length(coordinate[0]);
        }

        public double SurfaceArea() {
            double a = coordinate[0].Length(coordinate[1]);
            double b = coordinate[1].Length(coordinate[2]);
            double c = coordinate[2].Length(coordinate[0]);
            double nominator = Math.Sqrt((a + b + c) * (a + b - c) * (a - b + c) * (-a + b + c));
            return nominator / 4;
        }

        public override string Info() {
            return "\n\t Nazwa: " + name +
                    "\n\t Współrzędne: (" + coordinate[0].getX() + ", " + coordinate[0].getY() + "); (" + coordinate[1].getX() + ", " + coordinate[1].getY() + "); (" + coordinate[2].getX() + ", " + coordinate[2].getY() + ")" +
                    "\n\t Obwód: " + this.Circuit() +
                    "\n\t Pole: " + this.SurfaceArea();
        }
    }
}

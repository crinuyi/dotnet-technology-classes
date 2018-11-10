using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Square : GeometricalFigure, ICalculations {
        private new Coordinate[] coordinate = new Coordinate[4];

        public Square(string name, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) {
            this.name = name;
            coordinate[0] = new Coordinate(x1, y1);
            coordinate[1] = new Coordinate(x2, y2);
            coordinate[2] = new Coordinate(x3, y3);
            coordinate[3] = new Coordinate(x4, y4);
        }

        public double Circuit() {
            return coordinate[0].Length(coordinate[1]) * 4;
        }

        public double SurfaceArea() {
            return coordinate[0].Length(coordinate[1]) * coordinate[0].Length(coordinate[1]);
        }

        public override string Info() {
            return "\n\t Nazwa: " + name +
                   "\n\t Współrzędne: (" + coordinate[0].getX() + ", " + coordinate[0].getY() + "); (" + coordinate[1].getX() + ", " + coordinate[1].getY() + "); (" + coordinate[2].getX() + ", " + coordinate[2].getY() + "); (" + coordinate[3].getX() + ", " + coordinate[3].getY() + ")" +
                    "\n\t Obwód: " + this.Circuit() +
                    "\n\t Pole: " + this.SurfaceArea();
        }
    }
}

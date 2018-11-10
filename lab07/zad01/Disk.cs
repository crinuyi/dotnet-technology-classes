using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Disk : GeometricalFigure, ICalculations {
        double radius;
        private Coordinate origin;

        public Disk(string name, int x, int y, double radius) {
            this.name = name;
            origin = new Coordinate(x, y);
            this.radius = radius;
        }

        public double Circuit() {
            return 2 * Math.PI * radius;
        }

        public double SurfaceArea() {
            return Math.Pow(Math.PI * radius, 2);
        }

        public override string Info() {
            return "\n\t Nazwa: " + name +
                   "\n\t Środek: (" + origin.getX() + ", " + origin.getY() + ")" +
                    "\n\t Promień: " + radius +
                    "\n\t Obwód: " + this.Circuit() +
                    "\n\t Pole: " + this.SurfaceArea();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Coordinate {
        private int x;
        private int y;

        public int getX() {
            return x;
        }
        public int getY() {
            return y;
        }

        public Coordinate(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public double Length(Coordinate a) {
            return Math.Sqrt(Math.Pow(a.x - x, 2) + Math.Pow(a.y - y, 2));
        }
    }
}


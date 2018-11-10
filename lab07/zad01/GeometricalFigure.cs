using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    abstract class GeometricalFigure {
        protected string name;
        public Coordinate[] coordinate;

        public abstract string Info();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    public class UnitsOfMeasure {
        public class Quantity {
            private int piece;
            public int Piece {
                get { return piece; }
                set { this.piece = value; }
            }

            public int getSixty() {  //kopa
                return piece * 60;
            }

            public int getDozen() {  //tuzin
                return piece * 12;
            }

            public int getMendel() { //mendel
                return piece * 15;
            }
        }

        public class Length {
            private double meter;
            public double Meter {
                set { this.meter = value; }
                get { return meter; }
            }

            public double getMilimeter() {      //milimetr
                return meter * 0.001;
            }

            public double getInch() {           //cal
                return meter * 25.4;
            }

            public double getYard() {           //yard
                return meter * 0.9144;
            }

            public double getNauticalMile() {   //mila morska
                return meter * 1852;
            }

            public double getEnglishMile() {    //mila angielska
                return meter * 1609.344;
            }
        }

        public class Mass {
            private double kilogram;
            public double Kilogram {
                get { return kilogram; }
                set { this.kilogram = value; }
            }

            public double getGram() {    //gram
                return kilogram * 0.001;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    public class UnitsOfMeasure {
        public class Quantity {
            private int piece { get; set; }

            public Quantity(int piece) {
                this.piece = piece;
            }

            public int getSixty(int piece) {  //kopa
                return piece * 60;
            }

            public int getDozen(int piece) {  //tuzin
                return piece * 12;
            }

            public int getMendel(int piece) { //mendel
                return piece * 15;
            }
        }

        public class Length {
            public double getMilimeter(double meter) {      //milimetr
                return meter * 0.001;
            }

            public double getInch(double meter) {           //cal
                return meter * 25.4;
            }

            public double getYard(double meter) {           //yard
                return meter * 0.9144;
            }

            public double getNauticalMile(double meter) {   //mila morska
                return meter * 1852;
            }

            public double getEnglishMile(double meter) {    //mila angielska
                return meter * 1609.344;
            }
        }

        public class Mass {
            public double getGram(double kilogram) {    //gram
                return kilogram * 0.001;
            }
        }
    }
}

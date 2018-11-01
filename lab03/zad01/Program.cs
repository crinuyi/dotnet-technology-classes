using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Program {
        static void Main(string[] args) {
            UnitsOfMeasure.Quantity piece = new UnitsOfMeasure.Quantity();
            piece.Piece = 50;
            Console.WriteLine("** ILOŚĆ **\n" +
                "   Sztuki (bazowa wartość): {0}\n" +
                "   Kopa: {1}\n" +
                "   Tuzin: {2}\n" +
                "   Mendel: {3}\n\n",
                piece.Piece, piece.getSixty(), piece.getDozen(), piece.getMendel());

            UnitsOfMeasure.Length meter = new UnitsOfMeasure.Length();
            meter.Meter = 10;
            Console.WriteLine("** DŁUGOŚĆ **\n" +
                "   Metr (bazowa wartość): {0}\n" +
                "   Milimetr: {1}\n" +
                "   Cal: {2}\n" +
                "   Yard: {3}\n" +
                "   Mila morska: {4}\n" +
                "   Mila angielska: {5}\n\n",
                meter.Meter, meter.getMilimeter(), meter.getInch(), meter.getYard(), meter.getNauticalMile(), meter.getEnglishMile());

            UnitsOfMeasure.Mass kilogram = new UnitsOfMeasure.Mass();
            kilogram.Kilogram = 35;
            Console.WriteLine("** MASA **\n" +
                "   Kilogram (bazowa wartość): {0}\n" +
                "   Gram: {1}",
                kilogram.Kilogram, kilogram.getGram());
        }
    }
}

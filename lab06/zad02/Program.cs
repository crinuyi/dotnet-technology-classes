using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Program {
        static void Main(string[] args) {
            Merchandise merchandise = new Merchandise("szafa", 300.0, 3);
            Furniture furniture = new Furniture(merchandise, "Szafir");
            Wardrobe wardrobe = new Wardrobe(furniture, 200, 200, 200);
            Console.WriteLine(wardrobe.Description());
        }
    }
}

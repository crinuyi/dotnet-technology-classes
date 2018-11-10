using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Nails : Merchandise {
        protected int length;
        protected int thickness;
        protected string typeOfHead;

        public Nails(string name, double price, int quantity, int length, int thickness, string typeOfHead) 
            : base(name, price, quantity) {
            this.length = length;
            this.thickness = thickness;
            this.typeOfHead = typeOfHead;
        }

        public Nails(Merchandise merchandise, int length, int thickness, string typeOfHead)
            : base(merchandise) {
            this.length = length;
            this.thickness = thickness;
            this.typeOfHead = typeOfHead;
        }

        public override string Description() {
            return base.Description() + 
                "\n\t Długość: " + length +
                "\n\t Grubość: " + thickness +
                "\n\t Rodzaj główki: " + typeOfHead;
        }
    }
}

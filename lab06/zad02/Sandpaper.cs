using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Sandpaper : Merchandise {
        protected int width;
        protected int resilient;

        public Sandpaper(string name, double price, int quantity, int width, int resilient) : base(name, price, quantity) {
            this.width = width;
            this.resilient = resilient;
        }

        public Sandpaper(Merchandise merchandise, int width, int resilient)
            : base(merchandise) {
            this.width = width;
            this.resilient = resilient;
        }

        public override string Description() {
            return base.Description() +
                   "\n\t Szerokość: " + width +
                   "\n\t Ziarnistość: " + resilient;
        }
    }
}

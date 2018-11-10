using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Wardrobe : Furniture {
        protected int height;
        protected int width;
        protected int depth;

        public Wardrobe(string name, double price, int quantity, string nameOfCollection, int height, int width, int depth)
            : base(name, price, quantity, nameOfCollection) {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public Wardrobe(Furniture furniture, int height, int width, int depth)
            : base(furniture) {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public override string Description() {
            return base.Description() +
                   "\n\t Wysokość: " + height +
                   "\n\t Szerokość: " + width +
                   "\n\t Głębokość: " + depth;
        }
    }
}

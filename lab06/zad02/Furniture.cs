using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Furniture : Merchandise {
        protected string nameOfCollection;

        public Furniture(string name, double price, int quantity, string nameOfCollection) 
            : base(name, price, quantity) {
            this.nameOfCollection = nameOfCollection;
        }

        public Furniture(Merchandise merchandise, string nameOfCollection)
            : base(merchandise) {
            this.nameOfCollection = nameOfCollection;
        }

        public Furniture(Furniture furniture)
            : this(furniture.name, furniture.price, furniture.quantity, furniture.nameOfCollection) { }

        public override string Description() {
            return base.Description() +
                   "\n\t Nazwa kolekcji: " + nameOfCollection;
        }
    }
}

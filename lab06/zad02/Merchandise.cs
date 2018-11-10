using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Merchandise {
        public string name;
        public double price;
        public int quantity;

        public Merchandise(string name, double price, int quantity) {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public Merchandise(Merchandise merchandise)
            : this(merchandise.name, merchandise.price, merchandise.quantity) { }

        public virtual string Description() {
            return "\n\t Nazwa: " + name +
                   "\n\t Cena: " + price +
                   "\n\t Ilość: " + quantity;
        }
    }
}

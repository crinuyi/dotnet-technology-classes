using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Car {
        private Engine engine;
        private Point point;
        private string brand;
        private string model;

        public Car(string brand, string model, int mileage, int x, int y) {
            this.brand = brand;
            this.model = model;
            this.engine = new Engine(mileage);
            this.point = new Point(x, y);

        }
    }
}

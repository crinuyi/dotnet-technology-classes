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

        public Car(string brand, string model, int capacity, int x, int y) {
            this.brand = brand;
            this.model = model;
            this.engine = new Engine(capacity);
            this.point = new Point(x, y);
        }

        public Car(string brand, string model, int capacity, Point point)
            : this(brand, model, capacity, point.getX(), point.getY()) { }

        public Car(string brand, string model, int capacity)
            : this(brand, model, capacity, 0, 0) { }

        //------------------------------------------------------------

        public void getInfo() {
            Console.WriteLine("\n\n-----------------------------\n" +
                "INFORMACJE O SAMOCHODZIE:\n" +
                "   marka: {0}\n" +
                "   model: {1}\n" +
                "   pojemność silnika: {2}\n" +
                "   położenie na mapie: ({3}, {4})\n",
                brand, model, engine.getMileage(), point.getX(), point.getY());
        }

        public void changeBrand(string newBrand) {
            brand = newBrand;
        }

        public void changeModel(string newModel) {
            model = newModel;
        }

        public void changeCapacity(int newCapacity) {
            engine.changeCapacity(newCapacity);
        }

        public void changePosition(int newX, int newY) {
            point.setX(newX);
            point.setY(newY);
        }

        public Car clone() { //kopiowanie płytkie
            return (Car)this.MemberwiseClone(); 
        }

        public Car(Car prototype) { //kopiowanie głębokie
            brand = prototype.brand;
            model = prototype.model;
            engine = new Engine(prototype.engine);
            point = prototype.point;
        }
    }
}

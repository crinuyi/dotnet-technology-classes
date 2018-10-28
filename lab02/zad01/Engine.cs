using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Engine {
        private int capacity;

        public Engine(int mileage) {
            this.capacity = mileage;
        }

        public int getMileage() { return capacity; }
        public void setMileage(int newMileage) { capacity = newMileage; }

        public Engine(Engine prototype) {
            capacity = prototype.capacity;
        }

        public void changeCapacity(int newCapacity) {
            capacity = newCapacity;
        }
    }
}

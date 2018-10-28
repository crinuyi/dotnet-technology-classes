using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Engine {
        private int mileage;

        public Engine(int mileage) {
            this.mileage = mileage;
        }

        public int getMileage() { return mileage; }
        public void setMileage(int newMileage) { mileage = newMileage; }

        public Engine(Engine prototype) { mileage = prototype.mileage; }
    }
}

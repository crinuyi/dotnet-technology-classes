using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Car {
        internal string brand;
        internal string model;
        internal int yearOfProduction;
        internal decimal price;

        public Car(string brand, string model, int yearOfProduction, decimal price) {
            this.brand = brand;
            this.model = model;
            this.yearOfProduction = yearOfProduction;
            this.price = price;
        }
    }

    public class CompareByYear : IComparer {
        public int Compare(object a, object b) {
            Car c1 = (Car)a;
            Car c2 = (Car)b;
            if (c1.yearOfProduction > c2.yearOfProduction)
                return 1;
            if (c2.yearOfProduction > c1.yearOfProduction)
                return -1;
            else
                return 0;
        }
    }
}

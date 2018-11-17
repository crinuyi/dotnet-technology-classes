using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    public class Car {
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

        public static List<Car> AddCars() {
            List<Car> cars = new List<Car>();
            Car car1 = new Car("Audi", "A8", 1994, 56424);
            Car car2 = new Car("Ford", "GT", 2016, 78671);
            Car car3 = new Car("Porsche", "911", 2005, 76545);
            Car car4 = new Car("Ford", "S-Max", 2015, 76432);
            Car car5 = new Car("Audi", "TT", 1998, 65443);
            Car car6 = new Car("BMW", "i3", 2013, 65874);
            Car car7 = new Car("BMW", "X6", 2008, 79851);
            Car car8 = new Car("Ford", "Mustang", 2014, 98763);
            Car car9 = new Car("Porsche", "911", 2003, 78655);
            Car car10 = new Car("Audi", "A2", 2000, 54367);
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);
            cars.Add(car6);
            cars.Add(car7);
            cars.Add(car8);
            cars.Add(car8);
            cars.Add(car9);
            cars.Add(car10);
            return cars;
        }
    }

    public class CompareByYear : IComparer<Car> {
        public int Compare(Car a, Car b) {
            if (a.yearOfProduction > b.yearOfProduction)
                return 1;
            if (b.yearOfProduction > a.yearOfProduction)
                return -1;
            else
                return 0;
        }
    }

    public class CompareByPrice : IComparer<Car> {
        public int Compare(Car a, Car b) {
            if (a.price > b.price)
                return 1;
            if (b.price > a.price)
                return -1;
            else
                return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Program {
        static void Main(string[] args) {
            int intTemp;
            CompareByYear compareByYear = new CompareByYear();
            CompareByPrice compareByPrice = new CompareByPrice();

            //dodanie samochodów do programu
            List<Car> cars = Car.AddCars();
            Console.WriteLine(
                "\n\n" +
                "\tWybierz po czym chcesz sortować samochody:\n" +
                "\t 1: marka\n" +
                "\t 2: model\n" +
                "\t 3: rok produkcji\n" +
                "\t 4: cena\n" +
                "\tAby wyświetlić nieposortowane auta wpisz 5.\n");
            intTemp = Convert.ToInt32(Console.ReadLine());

            switch (intTemp) {
                case 1: {
                        //Użycie LINQ
                        var sortedCars = cars.OrderBy(x => x.brand).ToList();
                        foreach (Car car in sortedCars)
                            Console.WriteLine(
                                car.brand + ", " +
                                car.model + ", " +
                                car.yearOfProduction + ", " +
                                car.price + " zł");
                        break;
                    }
                case 2: {
                        //Użycie LINQ
                        var sortedCars = cars.OrderBy(x => x.model);
                        foreach (Car car in sortedCars)
                            Console.WriteLine(
                                car.brand + ", " +
                                car.model + ", " +
                                car.yearOfProduction + ", " +
                                car.price + " zł");
                        break;
                    }
                case 3: {
                        //użycie IComparer
                        cars.Sort(compareByYear);
                        foreach (Car car in cars)
                            Console.WriteLine(
                                car.brand + ", " +
                                car.model + ", " +
                                car.yearOfProduction + ", " +
                                car.price + " zł");
                        break;
                    }
                case 4: {
                        //użycie IComparer
                        cars.Sort(compareByPrice);
                        foreach (Car car in cars)
                            Console.WriteLine(
                                car.brand + ", " +
                                car.model + ", " +
                                car.yearOfProduction + ", " +
                                car.price + " zł");
                        break;
                    }
                case 5: {
                        foreach (Car car in cars)
                            Console.WriteLine(
                                car.brand + ", " +
                                car.model + ", " +
                                car.yearOfProduction + ", " +
                                car.price + " zł");
                        break;
                    }
            }
        }
    }
}

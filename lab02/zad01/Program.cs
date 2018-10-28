using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Program {
        static void Main(string[] args) {
            Car car1 = new Car("Opel", "Astra", 100000, 4560, 3256);
            car1.getInfo();
            Car car2 = new Car("Opel", "Zafira", 50000);
            car2.getInfo();
            Car car3 = car1.clone();    //klonowanie płytkie
            car3.getInfo();
            car3.changeCapacity(30);
            car1.getInfo();             //powinna być wartość 100000, a jest 30, bo dzielą silnik
            car3.getInfo();
            Car car4 = new Car(car2);   //klonowanie głębokie
            car4.getInfo();
            car4.changeCapacity(30);
            car2.getInfo();
            car4.getInfo();             //dla każdego auta jest inna pojemność silnika
        }
    }
}

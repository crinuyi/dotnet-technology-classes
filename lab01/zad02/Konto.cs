using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Konto {
        private readonly Osoba osoba;
        private double saldo;
        private string pin;

        public Konto(Osoba osoba) {
            this.osoba = osoba;
            this.saldo = 0;
            this.pin = "0000";
        }

        public void zmienPin() {
            bool flag = false;
            do {
                Console.WriteLine(" podaj PIN:");
                string newPin = Console.ReadLine();
                if (newPin == pin) {
                    flag = true;
                    Console.WriteLine(" nowy PIN:");
                    newPin = Console.ReadLine();
                    pin = newPin;
                    Console.WriteLine(" nowy PIN został ustawiony!\n");

                }
                else
                    Console.WriteLine(" podałeś zły PIN! spróbuj ponownie.\n");
            } while (flag == false);
        }

        public void wplac() {
            Console.WriteLine(" podaj kwotę do wpłaty:");
            double amount = Convert.ToDouble(Console.ReadLine());
            saldo += amount;
            Console.WriteLine(" pieniądze zostały wpłacone!\n");
        }

        public int wyplac() {
            Console.WriteLine(" podaj kwotę, jaką chcesz wypłacić:");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (saldo - amount < 0) {
                Console.WriteLine(" nie można wypłacić pieniędzy (brak możliwości debetu)!\n");
                return 1;
            }
            else {
                saldo -= amount;
                Console.WriteLine(" pieniądze zostały wypłacone.\n");
                return 0;
            }
        }

        public void sprawdzSaldo() {
            Console.WriteLine(" saldo wynosi {0} zł.\n", saldo);
        }

        public void info() {
            bool flag = false;
            do {
                Console.WriteLine(" podaj PIN:");
                string inputPin = Console.ReadLine();
                if (inputPin == pin) {
                    flag = true;
                    Console.WriteLine(" ** INFORMACJE **\n" +
                                    " właściciel: {0} {1}\n" +
                                    " saldo: {2}", osoba.getImie(), osoba.getNazwisko(), saldo);

                }
                else
                    Console.WriteLine(" podałeś zły PIN! spróbuj ponownie.\n");
            } while (flag == false);
        }
    }
}

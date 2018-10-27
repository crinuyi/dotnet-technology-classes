using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Konto {
        private readonly Osoba osoba;
        private decimal saldo;
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
                    pin = newPin;
                    Console.WriteLine(" nowy PIN został ustawiony! {0}", pin);

                }
                else
                    Console.WriteLine(" podałeś zły PIN! spróbuj ponownie.");
            } while (flag == false);
        }
    }
}

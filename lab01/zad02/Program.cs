using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Program {

        static void Main(string[] args) {
            Console.WriteLine(" witaj w programie stworzonym dla banków.\n  " +
                "podaj swoje imię:");
            string imie = Console.ReadLine();
            Console.WriteLine(" podaj swoje nazwisko:");
            string nazwisko = Console.ReadLine();
            Osoba osoba = new Osoba(imie, nazwisko);
            Konto konto = new Konto(osoba);
            Console.WriteLine(" witaj {0} {1}.\n" +
                " twój PIN to 0000. czy chcesz go zmienić? (T/N)", imie, nazwisko);
            string yn = Console.ReadLine();
            if (yn == "T")
                konto.zmienPin();

            //interfejs
            int i;
            do {
                Console.WriteLine("podaj twoj wybor:\n" +
                    "1. zmień PIN\n" +
                    "2. wpłać pieniądze\n" +
                    "3. wypłać pieniądze\n" +
                    "4. sprawdź saldo\n" +
                    "5. informacje o koncie\n" +
                    "6. wyjdź");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i) {
                    case 1:
                        konto.zmienPin();
                        break;
                    case 2:
                        //konto.wplac();
                        break;
                    case 3:
                        //konto.wyplac();
                        break;
                    case 4:
                        //konto.sprawdzSaldo();
                        break;
                    case 5:
                        //konto.info();
                        break;
                }
            } while (i != 6);

        }
    }
}

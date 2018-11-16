using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    class Program {
        static void Main(string[] args) {
            int intTemp = -1;

            //dodanie samochodów do programu
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

            do {
                Console.WriteLine(
                    "\tWitaj w programie zawierającym listę samochodów dostępnych w komisie.\n" +
                    "\tWybierz po czym chcesz sortować samochody:\n" +
                    "\t 1: marka\n" +
                    "\t 2: model\n" +
                    "\t 3: rok produkcji\n" +
                    "\t 4: cena\n" +
                    "\tAby zamknąć program wpisz 0.");
                intTemp = Convert.ToInt32(Console.ReadLine());

                switch (intTemp) {
                    case 1: {
                            break;
                        }
                    case 2: {
                            break;
                        }
                    case 3: {
                            
                            break;
                        }
                    case 4: {
                            break;
                        }
                    default:
                        Console.WriteLine("\tWpisałeś niepoprawną wartość!\n");
                        break;
                }
            } while (intTemp != 0);
        }
    }
}

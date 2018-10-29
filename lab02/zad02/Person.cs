using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Person {
        private string name;
        private string surname;
        private Address address;

        public Person(string name, string surname, string streetName, string city, int houseNumber, int apartmentNumber) {
            this.name = name;
            this.surname = surname;
            address = new Address(streetName, city, houseNumber, apartmentNumber);
        }

        public string getName() { return name; }
        public string getSurname() { return surname; }
        public Address getAddress() { return address; }

        public Person(string name, string surname, Address address)
            : this(name, surname, address.getCity(), address.getStreetName(), address.getHouseNumber(), address.getApartmentNumber()) { }

        public Person(string name, Address address)
            : this(name, "Kowalski", address) { }

        public Person(string name, int houseNumber, int apartmentNumber)
            : this(name, new Address(houseNumber, apartmentNumber)) { }

        public Person clone() {
            return (Person)this.MemberwiseClone();
        }

        public Person(Person prototype) {
            name = prototype.name;
            surname = prototype.surname;
            address = new Address(prototype.address);
        }

        public void showInfo() {
            Console.WriteLine("\n **INFORMACJE**\n" +
                "   imie: {0}\n" +
                "   nazwisko: {1}\n" +
                "   adres: {2}, {3}, {4}/{5}",
                getName(), getSurname(), getAddress().getCity(), getAddress().getStreetName(), getAddress().getHouseNumber(), getAddress().getApartmentNumber());
        }
    }
}

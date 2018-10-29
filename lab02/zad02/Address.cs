using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    struct Address {
        private string streetName;
        private string city;
        private int houseNumber;
        private int apartmentNumber;

        public Address(string streetName, string city, int houseNumber, int apartmentNumber) {
            this.streetName = streetName;
            this.city = city;
            this.houseNumber = houseNumber;
            this.apartmentNumber = apartmentNumber;
        }

        public Address(int houseNumber, int apartmentNumber, string city)
            : this("Aleje Jerozolimskie", city, houseNumber, apartmentNumber) { }

        public Address(string streetName, int houseNumber, int apartmentNumber)
            : this(streetName, "Warszawa", houseNumber, apartmentNumber) { }

        public Address(int houseNumber, int apartmentNumber)
            :this("Aleje Jerozolimskie", "Warszawa", houseNumber, apartmentNumber) { }

        public Address(Address prototype) {
            streetName = prototype.streetName;
            city = prototype.city;
            houseNumber = prototype.houseNumber;
            apartmentNumber = prototype.apartmentNumber;
        }

        public string getStreetName() { return streetName; }
        public string getCity() { return city; }
        public int getHouseNumber() { return houseNumber; }
        public int getApartmentNumber() { return apartmentNumber; }

        public void setStreetName(string newStreetName) { streetName = newStreetName; }
        public void setCity(string newCity) { city = newCity; }
        public void setHouseNumber(int newHouseNumber) { houseNumber = newHouseNumber; }
        public void setApartmentNumber(int newApartmentNumber) { apartmentNumber = newApartmentNumber; }
    }
}

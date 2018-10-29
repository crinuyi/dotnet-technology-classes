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
    }
}

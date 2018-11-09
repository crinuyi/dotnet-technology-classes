using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Person {
        protected String name;
        protected String surname;
        protected String birthdate;
        protected char sex;

        public Person(String name, String surname, String birthdate, char sex) {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.sex = sex;
        }

        public Person(Person person)
            : this(person.name, person.surname, person.birthdate, person.sex) { }
            
        public String info() {
            return "   imię: " + name + "\n" +
                "   nazwisko: " + surname + "\n" +
                "   data urodzenia: " + birthdate + "\n" +
                "   płeć: " + sex + "\n";
        }
    }
}

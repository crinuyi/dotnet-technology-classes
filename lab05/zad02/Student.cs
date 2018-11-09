using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Student : Person {
        protected int indexNumber;

        public Student(String name, String surname, String birthdate, char sex, int indexNumber) : base(name, surname, birthdate, sex) {
            this.indexNumber = indexNumber;
        }

        public Student(Student student)
            : this(student.name, student.surname, student.birthdate, student.sex, student.indexNumber) { }

        public Student(Person person, int indexNumber)
            : base(person) { this.indexNumber = indexNumber; }

        public new String info(){
            return base.info() + "   numer indeksu: " + indexNumber + "\n";
        }
    }
}

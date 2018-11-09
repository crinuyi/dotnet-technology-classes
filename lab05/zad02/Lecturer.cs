using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Lecturer : Person {
        protected String academicTitle;

        public Lecturer(String name, String surname, String birthdate, char sex, String academicTitle) : base(name, surname, birthdate, sex) {
            this.academicTitle = academicTitle;
        }

        public Lecturer(Person person, String academicTitle)
            : base(person) { this.academicTitle = academicTitle; }

        public new String info() {
            return base.info() + "   tytuł naukowy: " + academicTitle + "\n";
        }
    }
}

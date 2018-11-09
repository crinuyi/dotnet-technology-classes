using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Stipendist : Student {
        protected int amountOfMoney;

        public Stipendist(String name, String surname, String birthdate, char sex, int indexNumber, int amountOfMoney) : base(name, surname, birthdate, sex, indexNumber) {
            this.amountOfMoney = amountOfMoney;
        }

        public Stipendist(Student student, int amountOfMoney)
            : base(student) { this.amountOfMoney = amountOfMoney; }

        public new String info() {
            return base.info() + "   kwota stypendium: " + amountOfMoney + " zł\n";
        }
    }
}

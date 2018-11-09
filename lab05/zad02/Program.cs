using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Program {
        static void Main(string[] args) {
            Person person = new Person("Adam", "Nowak", "02-02-1999", 'M');
            Console.WriteLine(person.info() + "\n");

            Student student01 = new Student("Jan", "Kowalski", "03-03-1993", 'M', 333333);
            Console.WriteLine(student01.info() + "\n");
            Student student02 = new Student(person, 444444);
            Console.WriteLine(student02.info() + "\n");

            Lecturer lecturer = new Lecturer(student01, "doktor");
            Console.WriteLine(lecturer.info() + "\n");

            Stipendist stipendist = new Stipendist("Maria", "Nowak", "05-05-1995", 'K', 777777, 200);
            Console.WriteLine(stipendist.info() + "\n");
        }
    }
}

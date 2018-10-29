using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    class Program {
        static void Main(string[] args) {
            Person p1 = new Person("Jan", 4, 6);
            Person p2 = p1.clone();
            Person p3 = new Person(p1);

            p1.showInfo();
            p2.showInfo();
            p3.showInfo();
        }
    }
}

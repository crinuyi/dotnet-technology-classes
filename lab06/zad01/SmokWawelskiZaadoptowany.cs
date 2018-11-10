using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo {
    class SmokWawelskiZaadoptowany : Zwierze {
        public override void WydajGlos() {
            Console.WriteLine("whoooosh");
        }

        public override string NazwaLacinska {
            get { return "draco wawel"; }
        }

        public override string ToString() {
            return "smok wawelski";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad01 {
    static class IntExtension {
        public static int factorial(this int x) {
            if (x == 0)
                return 1;
            else
                return x * factorial(x - 1);
        }

        public static int binomial(this int x, int y) {
            if ((x == y) || (y == 0))
                return 1;
            else
                return binomial(x - 1, y) + binomial(x - 1, y - 1);
        }
    }
}

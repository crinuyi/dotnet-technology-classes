using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad02 {
    public class NumberOfDays {
        private string[] months = {
            "styczeń",
            "luty",
            "marzec",
            "kwiecień",
            "maj",
            "czerwiec",
            "lipiec",
            "sierpień",
            "wrzesień",
            "październik",
            "listopad",
            "grudzień"
        };
        private int[] days = {
            31,
            28,
            31,
            30,
            31,
            30,
            31,
            31,
            30,
            31,
            30,
            31
        };

        private int FindNumberOfDays(string month) {
            for(int i=0; i<months.Length; i++) {
                if (month.ToLower().Equals(months[i]))
                    return days[i];
            }
            return 1;
        }

        //indeksator
        public int this[string month] {
            get => FindNumberOfDays(month);
        }
    }
}

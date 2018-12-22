using System;
using System.Collections.Generic;

namespace ASPNETproject.Models {
    public class Scale {
        public int ScaleID { get; set; }
        public string Name { get; set; }
        public ICollection<Figure> Figures { get; set; }
    }
}
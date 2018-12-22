using System;
using System.Collections.Generic;

namespace ASPNETproject.Models {
    public class Classification {
        public int ClassificationID { get; set; }
        public string Name { get; set; }
        public ICollection<Figure> Figures { get; set; }
    }
}
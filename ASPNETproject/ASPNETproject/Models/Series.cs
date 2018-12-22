using System;
using System.Collections.Generic;

namespace ASPNETproject.Models {
    public class Series {
        public int SeriesID { get; set; }
        public string Name { get; set; }
        public ICollection<Figure> Figures { get; set; }
    }
}
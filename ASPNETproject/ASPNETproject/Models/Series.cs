using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ASPNETproject.Models {
    public class Series {
        public int SeriesID { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }

        //[DisplayName("Figurki")]
        //public ICollection<Figure> Figures { get; set; }
    }
}
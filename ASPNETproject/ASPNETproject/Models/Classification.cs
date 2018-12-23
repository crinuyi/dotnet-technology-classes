using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ASPNETproject.Models {
    public class Classification {
        public int ClassificationID { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }

        public ICollection<Figure> Figures { get; set; }
    }
}
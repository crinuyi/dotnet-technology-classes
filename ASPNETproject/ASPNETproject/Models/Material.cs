using System.Collections.Generic;
using System.ComponentModel;

namespace ASPNETproject.Models {
    public class Material {
        public int MaterialID { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }

        //[DisplayName("Figurki")]
        //public ICollection<Figure> Figures { get; set; }
    }
}
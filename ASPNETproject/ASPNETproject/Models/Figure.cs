using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETproject.Models {
    public class Figure {
        public int FigureID { get; set; }
        public string Name { get; set; }
        public Classification Classification { get; set; }
        public Producent Producent { get; set; }
        public Scale Scale { get; set; }
        public Material Material { get; set; }
        public Series Series { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
    }
}
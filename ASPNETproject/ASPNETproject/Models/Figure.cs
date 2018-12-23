using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASPNETproject.Models {
    public class Figure {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FigureID { get; set; }

        [DisplayName("Nazwa")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Pole jest wymagane.")]
        public string Name { get; set; }

        [DisplayName("Skala")]
        [DataType(DataType.Text)]
        [RegularExpression("1:[0-9]*", ErrorMessage = "Skala musi mieć następującą składnię: 1:[liczba].")]
        public string Scale { get; set; }

        [DisplayName("Data wydania")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DisplayName("Cena")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Pole jest wymagane.")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        [DisplayName("Typ")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Pole jest wymagane.")]
        public Classification Classification { get; set; }

        [DisplayName("Seria")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Pole jest wymagane.")]
        public Series Series { get; set; }

        [DisplayName("Materiały")]
        //[DataType(DataType.MultilineText)]
        public ICollection<Material> Materials { get; set; }

        [DisplayName("Producenci")]
        //[DataType(DataType.MultilineText)]
        public ICollection<Producent> Producents { get; set; }

    }
}
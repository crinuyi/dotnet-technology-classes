using System.ComponentModel;

namespace ASPNETproject.Models {
    public class Producent {

        public int ProducentID { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }
    }
}
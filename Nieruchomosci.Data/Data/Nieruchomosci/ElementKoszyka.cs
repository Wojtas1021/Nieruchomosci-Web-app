using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nieruchomosci.Data.Data.Nieruchomosci
{
    public class ElementKoszyka
    {
        [Key]
        public int IdElementuKoszyka { get; set; }
        public string IdSesjiKoszyka { get; set; }// identyfikator przeglądarki
        public int IdNieruchomosci { get; set; }
        public Nieruchomosc Nieruchomosc { get; set; }
        public int Ilosc { get; set; }
        public DateTime DataUtworzenia { get; set; }
    }
}

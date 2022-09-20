using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nieruchomosci.Data.Data.CMS
{
    public class Parametr
    {
        [Key]
        public int IdParametru { get; set; }

        [Required(ErrorMessage = "Kod jest wymagany")]
        [MaxLength(10, ErrorMessage = "Kod powinien zawierać max 10 znaków")]
        public string Kod { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [MaxLength(40, ErrorMessage = "Nazwa powinna zawierać max 40 znaków")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Wartość jest wymagana")]
        [Display(Name = "Wartość")]
        public string Wartosc { get; set; }
        public string? Opis { get; set; }

        [Display(Name = "Komentarz")]
        [Column(TypeName = "nvarchar(250)")]
        public string? Komentarz { get; set; }

        [Display(Name = "Przycisk")]
        public string? Przycisk { get; set; }

        [Display(Name = "Treść przycisku")]
        public string? TrescPrzycisku { get; set; }

        public DateTime DataUtworzenia { get; set; }

        [Display(Name = "Dodał")]
        public string PracownikDodajacy { get; set; }

        public DateTime DataEdycji { get; set; } = DateTime.Now;

        [Display(Name = "Edytował")]
        public string PracownikEdytujacy { get; set; }

        [Display(Name = "Usunięto")]
        public DateTime? DataUsuniecia { get; set; }

        [Display(Name = "Usunął")]
        public string? PracownikUsuwajacy { get; set; }

        public bool CzyAktywny { get; set; }
    }
}

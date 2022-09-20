using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nieruchomosci.Data.Data.Nieruchomosci
{
    public class RodzajNieruchomosci
    {
        [Key]
        public int IdRodzajuNieruchomosci { get; set; }

        [Required(ErrorMessage = "Kod jest wymagany")]
        [MinLength(3, ErrorMessage = "Kod powinien zawierać min 3 znaki")]
        public string Kod { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [MaxLength(30, ErrorMessage = "Nazwa powinna zawierać max 30 znaków")]
        public string Nazwa { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? Opis { get; set; }

        public List<Nieruchomosc>? Nieruchomosc { get; set; }
        public DateTime DataUtworzenia { get; set; }

        [Display(Name = "Kto dodał")]
        public string PracownikDodajacy { get; set; }

        public DateTime DataEdycji { get; set; } = DateTime.Now;

        [Display(Name = "Kto edytował")]
        public string PracownikEdytujacy { get; set; }

        [Display(Name = "Kiedy usunięto")]
        public DateTime? DataUsuniecia { get; set; }

        [Display(Name = "Kto usunął")]
        public string? PracownikUsuwajacy { get; set; }

        public bool CzyAktywny { get; set; }
    }
}


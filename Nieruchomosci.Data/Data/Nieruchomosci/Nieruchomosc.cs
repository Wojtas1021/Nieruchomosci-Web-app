using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nieruchomosci.Data.Data.Nieruchomosci
{
    public class Nieruchomosc
    {
        [Key]
        public int IdNieruchomosci { get; set; }
        
        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [MaxLength(35, ErrorMessage = "Tytuł powinien zawierać max 35 znaków")]
        [MinLength(10, ErrorMessage = "Tytuł powinien zawierać min 10 znaków")]
        [Display(Name = "Tytuł")]
        public string Tytul { get; set; }
        
        [Required(ErrorMessage = "Adres jest wymagany")]
        public string Adres { get; set; }
      
        [Required(ErrorMessage = "Opis jest wymagany")]
        public string Opis { get; set; }

        [Required(ErrorMessage = "Forma jest wymagana")]
        [Display(Name = "Najem/Sprzedaż")]
        public string Forma { get; set; }

        [Required(ErrorMessage = "Cena jest wymagana")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Cena { get; set; }

        [Required(ErrorMessage = "Powierzchnia jest wymagana")]
        public string Powierzchnia { get; set; }
        public string Foto { get; set; }
        public int? Osoby { get; set; }
        public int? Ocena { get; set; }
        public string? Sypialnia { get; set; }
        public string? Lazienka { get; set; }
        public string? Klimatyzacja { get; set; }
        public string? Parking { get; set; }
        public string? WiFi { get; set; }
        public string? Basen { get; set; }
        public string? Silownia { get; set; }
        public string? Monitoring { get; set; }
        public string? Pralnia { get; set; }
        public int IdRodzajuNieruchomosci { get; set; }
        public RodzajNieruchomosci RodzajNieruchomosci { get; set; }
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
        
        [Display(Name ="Towar promowany")]
        public bool Promocja { get; set; }
    }
}

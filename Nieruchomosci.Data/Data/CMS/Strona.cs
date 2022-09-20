using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nieruchomosci.Data.Data.CMS
{
    public class Strona
    {
        [Key]
        public int IdStrony { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł linku")]
        [MaxLength(15, ErrorMessage = "Tytuł powinien zawierać max 25 znaków")]
        [Display(Name = "Tytuł odnośnika")]
        public string LinkTytul { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł strony")]
        [MaxLength(30, ErrorMessage = "Tytuł strony powinien zawierać max 30 znaków")]
        [Display(Name = "Tytuł strony")]
        public string Tytul { get; set; }

        [Display(Name = "Foto")]
        public string? Foto { get; set; }

        [Display(Name = "Ikona")]
        public string? Ikona { get; set; }

        [Display(Name = "Treść")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Tresc { get; set; }

        [Display(Name = "Pozycja wyświetlania")]
        [Required(ErrorMessage = "Pozycja jest wymagana")]
        public int Pozycja { get; set; }

        [Display(Name = "Utworzony")]
        public DateTime DataUtworzenia { get; set; }

        [Display(Name = "Dodał")]
        public string? PracownikDodajacy { get; set; }

        [Display(Name = "Data edycji")]
        public DateTime DataEdycji { get; set; }

        [Display(Name = "Edytował")]
        public string? PracownikEdytujacy { get; set; }

        [Display(Name = "Data usunięcia")]
        public DateTime? DataUsuniecia { get; set; }

        [Display(Name = "Usunął")]
        public string? PracownikUsuwajacy { get; set; }
        public string? NazwaWidoku { get; set; }

        public bool CzyAktywny { get; set; }
    }
}

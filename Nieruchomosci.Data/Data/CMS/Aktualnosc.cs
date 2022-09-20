using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nieruchomosci.Data.Data.CMS
{
    public class Aktualnosc
    {
        [Key]
        public int IdAktualnosci { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł aktualności")]
        [MaxLength(15, ErrorMessage = "Tytuł powinien zawierać max 15 znaków")]
        [Display(Name = "Tytuł aktualności")]
        public string LinkTytul { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł aktualności")]
        [MaxLength(30, ErrorMessage = "Tytuł aktualności powinien zawierać max 30 znaków")]
        [Display(Name = "Tytuł aktulaności")]
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

        [Display(Name = "Komentarz")]
        [Column(TypeName = "nvarchar(250)")]
        public string? Komentarz { get; set; }

        public DateTime DataUtworzenia { get; set; }

        [Display(Name = "Kto dodał")]
        public string PracownikDodajacy { get; set; }

        public DateTime DataEdycji { get; set; }

        [Display(Name = "Kto edytował")]
        public string PracownikEdytujacy { get; set; }

        [Display(Name = "Kiedy usunięto")]
        public DateTime? DataUsuniecia { get; set; }

        [Display(Name = "Kto usunął")]
        public string? PracownikUsuwajacy { get; set; }

        public bool CzyAktywny { get; set; }
    }
}

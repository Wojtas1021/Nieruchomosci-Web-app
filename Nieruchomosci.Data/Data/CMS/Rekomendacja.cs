using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nieruchomosci.Data.Data.CMS
{
    public class Rekomendacja
    {
        [Key]
        public int IdRekomendacji { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł rekomendacji")]
        [MaxLength(20, ErrorMessage = "Tytuł powinien zawierać max 20 znaków")]
        [Display(Name = "Tytuł rekomendacji")]
        public string LinkRekomendacji { get; set; }

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

        [Display(Name = "Przycisk")]
        public string? Przycisk { get; set; }

        public DateTime DataUtworzenia { get; set; }

        public DateTime DataPublikacji { get; set; }

        [Required]
        [Display(Name = "Autor")]
        public string Autor { get; set; }

        [Display(Name = "Ocena")]
        public int? Ocena { get; set; }

        public DateTime DataEdycji { get; set; } = DateTime.Now;

        public bool CzyPubliczny { get; set; }

        public bool CzyAktywny { get; set; }
    }
}

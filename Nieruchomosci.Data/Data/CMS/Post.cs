using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nieruchomosci.Data.Data.CMS
{
    public class Post
    {
        [Key]
        public int IdPostu { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł postu")]
        [MaxLength(20, ErrorMessage = "Tytuł powinien zawierać max 20 znaków")]
        [Display(Name = "Tytuł odnośnika")]
        public string LinkPostu { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł postu")]
        [MaxLength(30, ErrorMessage = "Tytuł postu powinien zawierać max 30 znaków")]
        [Display(Name = "Tytuł postu")]
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

        [Display(Name = "Przycisk")]
        public string Przycisk { get; set; }

        public DateTime DataUtworzenia { get; set; }

        public DateTime DataPublikacji { get; set; }

        [Display(Name = "Autor")]
        public string Autor { get; set; }

        public DateTime DataEdycji { get; set; }

        public bool CzyPubliczny { get; set; }

        public bool CzyAktywny { get; set; }
    }
}

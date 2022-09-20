using Microsoft.AspNetCore.Mvc;
using Nieruchomosci.Data.Data;
using Nieruchomosci.PortalWWW.Models;
using System.Diagnostics;

namespace Nieruchomosci.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NieruchomosciContext _context;
        public HomeController(NieruchomosciContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            ViewBag.ModelStrony =
                (
                from strona in _context.Strona
                orderby strona.Pozycja
                select strona
                ).ToList();

            ViewBag.ModelOferty =
                (
                from nieruchomosc in _context.Nieruchomosc
                where nieruchomosc.Promocja == true
                select nieruchomosc
                ).ToList();

            ViewBag.ModelParamTech =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "1"
                select parametr
                ).ToList();

            ViewBag.ModelPostyMiasto =
                (
                from post in _context.Post
                where post.CzyPubliczny == false
                select post
                ).ToList();

            ViewBag.ModelRekomendacje =
                (
                from rekomendacja in _context.Rekomendacja
                where rekomendacja.CzyPubliczny == true
                select rekomendacja
                ).ToList();

            ViewBag.ModelParametry =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "0"
                select parametr
                ).ToList();

            ViewBag.ModelGodziny =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "2"
                select parametr
                ).ToList();
            if (id == null)
                id = _context.Strona.First().IdStrony;
            var item = _context.Strona.Find(id);
            return View(item);

        }
        public IActionResult Nowosci(int? id)
        {
            ViewBag.ModelStrony =
                (
                from strona in _context.Strona
                orderby strona.Pozycja
                select strona
                ).ToList();

            ViewBag.ModelAktualnosci =
                (
                from aktualnosc in _context.Aktualnosc
                select aktualnosc
                ).ToList();

            ViewBag.ModelPostyMiasto =
                (
                from post in _context.Post
                where post.CzyPubliczny == false
                select post
                ).ToList();


            ViewBag.ModelParametry =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "0"
                select parametr
                ).ToList();

            ViewBag.ModelGodziny =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "2"
                select parametr
                ).ToList();

            if (id == null)
                id = _context.Strona.First().IdStrony;
            var item = _context.Strona.Find(id);
            return View(item);
        }
        public IActionResult Firma(int? id)
        {
            ViewBag.ModelStrony =
                (
                from strona in _context.Strona
                orderby strona.Pozycja
                select strona
                ).ToList();

            ViewBag.ModelTechniczne =
               (
               from parametr in _context.Parametr
               where parametr.Opis == "3"
               select parametr
               ).ToList();

            ViewBag.ModelParamTech =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "1"
                select parametr
                ).ToList();

            ViewBag.ModelRekomendacje =
                (
                from rekomendacja in _context.Rekomendacja
                where rekomendacja.CzyPubliczny == true
                select rekomendacja
                ).ToList();

            ViewBag.ModelParametry =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "0"
                select parametr
                ).ToList();

            ViewBag.ModelGodziny =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "2"
                select parametr
                ).ToList();

            if (id == null)
                id = _context.Strona.First().IdStrony;
            var item = _context.Strona.Find(id);
            return View(item);
        }
        public IActionResult Kontakt(int? id)
        {
            ViewBag.ModelStrony =
                (
                from strona in _context.Strona
                orderby strona.Pozycja
                select strona
                ).ToList();

            ViewBag.ModelOferty =
                (
                from nieruchomosc in _context.Nieruchomosc
                where nieruchomosc.Promocja == true
                select nieruchomosc
                ).ToList();

            ViewBag.ModelParamTech =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "1"
                select parametr
                ).ToList();

            ViewBag.ModelPostyMiasto =
                (
                from post in _context.Post
                where post.CzyPubliczny == false
                select post
                ).ToList();

            ViewBag.ModelRekomendacje =
                (
                from rekomendacja in _context.Rekomendacja
                where rekomendacja.CzyPubliczny == true
                select rekomendacja
                ).ToList();

            ViewBag.ModelParametry =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "0"
                select parametr
                ).ToList();

            ViewBag.ModelGodziny =
                (
                from parametr in _context.Parametr
                where parametr.Opis == "2"
                select parametr
                ).ToList();

            if (id == null)
                id = _context.Strona.First().IdStrony;
            var item = _context.Strona.Find(id);
            return View(item);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Nieruchomosci.Data.Data;
using Nieruchomosci.PortalWWW.Models.BusinessLogic;
using Nieruchomosci.PortalWWW.Models.NieruchomosciSklep;

namespace Nieruchomosci.PortalWWW.Controllers
{
    public class KoszykController : Controller
    {
        //połączenie z baza daneych - operacje na BD
        private readonly NieruchomosciContext _context;
        public KoszykController(NieruchomosciContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            KoszykB koszykB = new KoszykB(_context, this.HttpContext);
            DaneDoKoszyka daneDoKoszyka = new DaneDoKoszyka()
            {
                ElementKoszyka = await koszykB.GetElementKoszykaKlienta(),
                Razem = await koszykB.GetRazem()
            };
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

            return View(daneDoKoszyka);
        }
        //funkcja obsługująca przycisk do dodawania do koszyka
        public async Task<IActionResult> DodajDoKoszyka(int id)
        {
        ViewBag.ModelStrony =
         (
         from strona in _context.Strona
         orderby strona.Pozycja
         select strona
         ).ToList();

            KoszykB koszykB = new KoszykB(_context, this.HttpContext);
            koszykB.DodajDoKoszyka(await _context.Nieruchomosc.FindAsync(id));
            return RedirectToAction("Index");
        }
    }
}

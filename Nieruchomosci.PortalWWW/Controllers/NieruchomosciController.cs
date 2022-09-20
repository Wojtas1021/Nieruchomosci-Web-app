using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nieruchomosci.Data.Data;

namespace Nieruchomosci.PortalWWW.Controllers
{
    public class NieruchomosciController : Controller
    {
        private readonly NieruchomosciContext _context;
        public NieruchomosciController(NieruchomosciContext context)
        {
            _context = context;
        }
        //to jest funkcja, która dostarcza dane do widoku wyświetlajacego wszytkie nieruchomości
        public async Task<IActionResult> Index(int? id)//wyświetla rodzaje poprzez id
        {

            ViewBag.ModelStrony =
                 (
                 from strona in _context.Strona
                 orderby strona.Pozycja
                 select strona
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
            // pobieramy wszystkie rodzaje z bazy danych

            ViewBag.ModelRodzaje = await _context.RodzajNieruchomosci.ToListAsync();
            if(id == null)
                return View(await _context.Nieruchomosc.Where(n=>n.Promocja).ToListAsync());
            else
                return View(await _context.Nieruchomosc.Where(n=>n.IdRodzajuNieruchomosci==id).ToListAsync());
            /*  if(id == null)
            {
                var pierwszy = await _context.RodzajNieruchomosci.FirstAsync();
                id = pierwszy.IdRodzajuNieruchomosci;
            }
            // do widoku przekazuje listę nieruchomosci danego rodzaju
            return View(await _context.Nieruchomosc.Where(t=>t.IdRodzajuNieruchomosci==id).ToListAsync());
        */
        }
        public async Task<IActionResult> Szczegoly(int id)
        {

            ViewBag.ModelStrony =
         (
         from strona in _context.Strona
         orderby strona.Pozycja
         select strona
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

            ViewBag.ModelRodzaje = await _context.RodzajNieruchomosci.ToListAsync();
            return View(await _context.Nieruchomosc.Where(n=>n.IdNieruchomosci ==id).FirstOrDefaultAsync());
        }
        public async Task<IActionResult> Promocje()
        {
            return View(await _context.Nieruchomosc.Where(n => n.Promocja == true).ToListAsync());
        }

    }
}

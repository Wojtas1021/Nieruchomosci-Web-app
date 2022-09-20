using Microsoft.EntityFrameworkCore;
using Nieruchomosci.Data.Data;
using Nieruchomosci.Data.Data.Nieruchomosci;

namespace Nieruchomosci.PortalWWW.Models.BusinessLogic
{
    public class KoszykB
    {
        private readonly NieruchomosciContext _context;
        private string idSesjiKoszyka;
        public KoszykB(NieruchomosciContext context, HttpContext httpContext)
        {
            _context = context;
            idSesjiKoszyka = GetIdSesjiKoszyka(httpContext);
        }
        private string GetIdSesjiKoszyka(HttpContext httpContext)
        {
            if(httpContext.Session.Get("IdSesjiKoszyka") == null)
            {
                if(!string.IsNullOrWhiteSpace(httpContext.User.Identity.Name))
                {
                    httpContext.Session.SetString("IdSesjiKoszyka", httpContext.User.Identity.Name);
                }
                else
                {
                    Guid tempIdSesjiKoszyka = Guid.NewGuid();
                    httpContext.Session.SetString("IdSesjiKoszyka", tempIdSesjiKoszyka.ToString());
                }
            }
            return httpContext.Session.GetString("IdSesjiKoszyka");
        }
        public void DodajDoKoszyka(Nieruchomosc nieruchomosci)
        {
            //sprawdza czy w tabeli elementy koszyka znajduje się nieruchomosc, danej przeglądarki
            var tempElementKoszyka = _context.ElementKoszyka.Where(e => e.IdSesjiKoszyka == idSesjiKoszyka && e.IdNieruchomosci == nieruchomosci.IdNieruchomosci).FirstOrDefault();
            // jeżeli przegladarka ma już ten towar w koszyku, to przy każdym dodaniu zwiększamy jego ilość
            if(tempElementKoszyka != null)
            {
                tempElementKoszyka.Ilosc++;
            }
            else//jeżeli przeglarka w koszyku nie ma nieruchomosci, 
            {
                tempElementKoszyka = new ElementKoszyka()//dodajemy do koszyka jako element
                {
                    IdSesjiKoszyka = idSesjiKoszyka,//dodajemy do danej przegladarki
                    IdNieruchomosci = nieruchomosci.IdNieruchomosci,
                    Nieruchomosc = _context.Nieruchomosc.Find(nieruchomosci.IdNieruchomosci),
                    Ilosc = 1,
                    DataUtworzenia = DateTime.Now
                };
                _context.ElementKoszyka.Add(tempElementKoszyka);// dodanie do lokalnej kolekcji
            }
            _context.SaveChanges();// zapisujemy w bazie danych
        }
        //funkcja zwraca wszystkie elementu koszyka danego klienta
        public async Task<List<ElementKoszyka>>GetElementKoszykaKlienta()
        {
            return await _context.ElementKoszyka.Where(e => e.IdSesjiKoszyka == this.idSesjiKoszyka).Include(e=>e.Nieruchomosc).ToListAsync();
        }
        //funkcja zwraca sume wartosci towarow w koszyku danego klienta
        public async Task<decimal>GetRazem()
        {
            //zwracamy wszystkie iloczyny ilości razy cena nieruchomosci danego klienta
            var items =
            (
                from element in _context.ElementKoszyka
                where element.IdSesjiKoszyka == this.idSesjiKoszyka
                select element.Nieruchomosc.Cena * (decimal?)element.Ilosc
            );
            return await items.SumAsync() ?? 0;
        }
    }
}

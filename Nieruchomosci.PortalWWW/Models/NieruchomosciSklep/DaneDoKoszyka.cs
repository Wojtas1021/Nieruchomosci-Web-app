using Nieruchomosci.Data.Data.Nieruchomosci;

namespace Nieruchomosci.PortalWWW.Models.NieruchomosciSklep
{
    public class DaneDoKoszyka
    {
        public List<ElementKoszyka> ElementKoszyka { get; set; }
        public decimal Razem { get; set; }
    }
}

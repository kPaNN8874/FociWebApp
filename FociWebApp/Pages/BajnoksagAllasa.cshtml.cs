using FociWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FociWebApp.Pages
{
    public class BajnoksagAllasaModel : PageModel
    { private readonly FociDbContext _context;

        public BajnoksagAllasaModel(FociDbContext context)
        {
            _context = context;
        }
        public List<Meccs> meccsek;
        public List<CsapatStatisztika> csapatStatisztika;
        public void OnGet()
        {
            meccsek = _context.Meccsek.ToList();
            csapatStatisztika = new();
            foreach (var cs in meccsek.Select(x => x.HazaiCsapat).Distinct())
            {
                CsapatStatisztika ujCsapat = new();
                ujCsapat.CsapatNev = cs;
                csapatStatisztika.Add(ujCsapat);
            }
            foreach (var cs in csapatStatisztika)
            {
                cs.GyozelmekSzama = meccsek.Where(x => x.GyoztesCsapatNeve() == cs.CsapatNev).Count();
                cs.GyozelmekSzama = meccsek.Where(x => (x.HazaiCsapat == cs.CsapatNev || x.VendegCsapat == cs.CsapatNev) && x.GyoztesCsapatNeve() != cs.CsapatNev && x.GyoztesCsapatNeve() != "").Count();
                
            }

        }
    }
}

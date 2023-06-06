using PROJECTTRACKING.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECTTRACKING.Controllers
{
    public class GenelBakisController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();
        // GET: GenelBakis
        public ActionResult Index()
        {
            int projeSayisi = db.personelProjeleris.Count();
            ViewBag.projesayisi = projeSayisi;
            int tamamlananProje = db.personelProjeleris.Where(p => p.TamamlanmaDurumu == true).Count();
            ViewBag.tamamlananProje = tamamlananProje;
            return View();
        }
    }
}
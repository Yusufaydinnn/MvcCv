using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        DbCvEntities db = new DbCvEntities();
        // GET: Default
        public ActionResult Index()
        {
            var degerler = db.TblHakkımda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TblSosyalMedya.Where(x=> x.Durum == true).ToList();
            return PartialView(sosyalmedya);    

        }
        public PartialViewResult Deneyim() { 
            var Deneyimlerim = db.TblDeneyimlerim.ToList(); 
            return PartialView(Deneyimlerim);

        }
        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.TblEgitimlerim.ToList();
            return PartialView(egitimler);

        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TblYeteneklerim.ToList();
            return PartialView(yetenekler);

        }
        public PartialViewResult Hobilerim()
        {
            var hobiler = db.TblHobilerim.ToList();
            return PartialView(hobiler);

        }
        public PartialViewResult Sertifikalarim()
        {
            var sertifikalar = db.TblSertifikalarım.ToList();
            return PartialView(sertifikalar);

        }
        [HttpGet]
        public PartialViewResult iletisim() 
        { 
            var ietisim = db.Tblİletisim.ToList();
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(Tblİletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tblİletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}
using Skill_Profile.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skill_Profile.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            
            var degerler = c.Yetenekler.ToList();

            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(Skills y)
        {
            c.Yetenekler.Add(y);
            c.SaveChanges();
            return View();
        }
        public ActionResult YetenekSil(int id) /*buraya id yerine başka bir şey yazmak istersen:https://stackoverflow.com/questions/25014854/what-is-the-difference-in-passing-parameter-of-action-with-id-or-empid-in-mvc*/
        {
            var deger = c.Yetenekler.Find(id);
            c.Yetenekler.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult YetenekGoruntule(int id)
        {
            var deger = c.Yetenekler.Find(id);

            return View("YetenekGoruntule",deger);
        }
        
        [HttpPost]
        public ActionResult YetenekGoruntule(Skills al)
        {
            var deger = c.Yetenekler.Find(al.Id);
            deger.Aciklama=al.Aciklama;
            deger.Deger=al.Deger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
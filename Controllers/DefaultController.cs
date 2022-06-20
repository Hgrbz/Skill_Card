using Skill_Profile.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skill_Profile.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();

            var degerler = c.Yetenekler.ToList();

            return View(degerler);
        }
    }
}
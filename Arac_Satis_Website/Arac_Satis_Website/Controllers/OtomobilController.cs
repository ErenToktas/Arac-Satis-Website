using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Arac_Satis_Website.Models.entity;
namespace Arac_Satis_Website.Controllers
{
    public class OtomobilController : Controller
    {
        // GET: Otomobil
        Oto_SatisEntities db = new Oto_SatisEntities();
        public ActionResult Index()
        {
            var ss = db.Ilan.ToList();
            return View(ss);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;
//using System.Windows.Documents;

namespace mvcOtomasyon.Controllers
{
    public class HomeController : Controller
    {
        //public static List<Models.UrunDetayViewModel> modell = new List<Models.UrunDetayViewModel>();
        // GET: Home
        public ActionResult Index()
        {
            Models.UrunDetayViewModel model = new Models.UrunDetayViewModel();
            Models.Urun urun = new Models.Urun();
            urun.UrunId = 1;
            urun.UrunAdi = "Apple Watch";
            urun.UrunFiyati = 3500;

            Models.UrunResim urunresim = new Models.UrunResim();
            urunresim.UrunId = 1;
            urunresim.UrunResimId = 1;
            urunresim.UrunResimAciklamasi = "Saat";
            urunresim.UrunResimUrl = "resim1_url";

            //List urunresimlistesi = new List();
            //urunresimlistesi.Add(urunresim);

            List<Models.UrunResim> urunresimlistesi = new List<Models.UrunResim>();
            urunresimlistesi.Add(urunresim);
            //modell.a
            

            model.Urun = urun;
            //model.UrunResimleri = urunresimlistesi;

            return View(model);
        }
    }
}
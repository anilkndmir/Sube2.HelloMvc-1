using Microsoft.AspNetCore.Mvc;

namespace Sube2.HelloMvc.Controllers
{
    public class OgrenciController : Controller
    {
        public ViewResult Index()  //Action
        {
            return View();
        }

        public ViewResult OgrenciDetay(int id)
        {
            //Ogretmen ogrt = null;
            //Models.Ogrenci ogr = null;
            //Ders ds = null;
            //if (id == 1) 
            //{
            //    ogr= new Models.Ogrenci();
            //    ogr.Ad = "Ali";
            //    ogr.Soyad = "Veli";
            //    ogr.Numara = 123;

            //    ogrt = new Ogretmen();
            //    ogrt.Ad = "Mehmet";
            //    ogrt.Soyad = "Ahmet";
            //    ogrt.OgretmenId = 123;

            //    ds = new Ders();
            //    ds.kredi = 5;
            //    ds.DersId = 1;
            //    ds.DersAd = "Programlama";
            //}
            //else if (id == 2) 
            //{
            //    ogr = new Models.Ogrenci { Ad = "Ali", Soyad = "Veli", Numara = 123 };
            //}

            ////var model = Tuple.Create(ogr, ogrt);

            //ViewData["school"] = ogr;
            //ViewBag.student = ogr;
            //ViewBag.ogretmen = ogrt;

            //OkulViewModels vm = new OkulViewModels();
            //vm.ogretmen = ogrt;
            //vm.ogrenci = ogr;
            //vm.ders = ds;
            return View();
        }

        public ViewResult OgrenciListe()
        {
            

            return View();
        }



    }
}
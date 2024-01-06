using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Examples;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        void Topla()
        {
            int sayi1;
            int sayi2;
            sayi1 = 3;
            sayi2 = 4;
            int toplam = sayi1 + sayi2;
        }
        void Islemler()
        {
            Class1 c = new Class1();
            c.Topla();
        }
        void Messages()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Merhaba proje çok iyi duruyor";
            ViewBag.m3 = "Selamlar Hello Hi Bonjour";
        }
        int Toplama()
        {
            int sayi1 = 20;
            int sayi2 = 30;
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public IActionResult Index()
        {
            //view da viewBag leri görebilmek için Messages() Metodunu burada tanımlamak gerekir
            //Aksi Taktirde view da @viewBag.m1 olarak çağırsak bile gelmeyecektir
            Messages();
            return View();
        }
        public IActionResult Urunler()
        {
            Messages();
            ViewBag.t = Toplama();
            return View();
        }
    }
}

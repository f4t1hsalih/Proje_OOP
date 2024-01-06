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

        public IActionResult Index()
        {
            Messages();
            return View();
        }
    }
}

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
        int Cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int cevre = 2 * (kisa + uzun);
            return cevre;
        }
        string Cumle()
        {
            string c = "Merhaba Asp.Net Core";
            return c;
        }
        void MesajListesi(string parametre)
        {
            ViewBag.v = parametre;
        }
        void Kullanici(string username)
        {
            ViewBag.v = username;
        }
        int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public IActionResult Index()
        {
            //view da viewBag leri görebilmek için Messages() Metodunu burada tanımlamak gerekir
            //Aksi Taktirde view da @viewBag.m1 olarak çağırsak bile gelmeyecektir
            Messages();
            MesajListesi("Selamlarr");
            Kullanici("Ayşe");
            ViewBag.sonuc = Topla(20, 35);
            return View();
        }
        public IActionResult Urunler()
        {
            Messages();
            ViewBag.t = Toplama();
            ViewBag.c = Cevre();
            Kullanici("Mehmet");
            return View();
        }
        public IActionResult Musteriler()
        {
            ViewBag.cumle = Cumle();
            Kullanici("Maral");
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();

            sehirler.ID = 2;
            sehirler.Ulke = "Ukrayna";
            sehirler.Ad = "Kiev";
            sehirler.Nufus = 1000000;

            ViewBag.v1 = sehirler.ID;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v3 = sehirler.Ad;
            ViewBag.v4 = sehirler.Nufus;

            sehirler.ID = 3;
            sehirler.Ulke = "Makedonya";
            sehirler.Ad = "Üsküp";
            sehirler.Nufus = 500000;
            
            ViewBag.z1 = sehirler.ID;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.Ad;
            ViewBag.z4 = sehirler.Nufus;

            return View();
        }
    }
}

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
    }
}

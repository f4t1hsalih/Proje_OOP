using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();

        //Listeleme İşlemi
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }

        //Kaydetme İşlemi
        //Get işlemi gerçekleşince yapılacaklar
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        //Post işlemi gerçekleşince yapılacaklar
        [HttpPost]
        public IActionResult AddCustomer(Customer c)
        {
            //Kayıt yapmadan önce bazı şartları kontrol eder şartlar karşılanıyor ise kayıt yapar
            if (c.Name.Length >= 3 && c.City != "" && c.City.Length >= 3)
            {
                //c den gelen değerleri ekler
                context.Add(c);
                //Değişiklikleri kaydeder
                context.SaveChanges();
                //Index Action'una (Index Sayfası) yönlendirir
                return RedirectToAction("Index");
            }
            //Şartlar karşılanmıyor ise aynı sayfayı tekrar açar
            else
            {
                return View();
            }

        }

        //Silme İşlemi
        public IActionResult DeleteCustomer(int id)
        {
            //Silinecek değeri alıp value isimli değişkene atar
            var value = context.Customers.Where(x => x.ID == id).FirstOrDefault();
            //Değeri siler
            context.Remove(value);
            //Değişiklikleri kaydeder
            context.SaveChanges();
            //Index sayfasına yönlendirir
            return RedirectToAction("Index");
        }

        //Güncelleme İşlemi
        //Get işlemi gerçekleşince yapılacaklar
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.Customers.Where(x => x.ID == id).FirstOrDefault();
            return View(value);
        }
        //Post işlemi gerçekleşince yapılacaklar
        [HttpPost]
        public IActionResult UpdateCustomer(Customer c)
        {
            //Kayıt yapmadan önce bazı şartları kontrol eder şartlar karşılanıyor ise güncelleme yapar
            if (c.Name.Length >= 3 && c.City != "" && c.City.Length >= 3)
            {
                //Üzerinde değişiklik yapılacak veririyi alır
                var value = context.Customers.Where(x => x.ID == c.ID).FirstOrDefault();
                //Verinin CustomerCity Prop'una Sınıftan gelen(Güncelleme sayfasından gelen) değeri yazar
                value.City = c.City;
                //Verinin CustomerName Prop'una Sınıftan gelen(Güncelleme sayfasından gelen) değeri yazar
                value.Name = c.Name;
                //Değişiklikleri kaydeder
                context.SaveChanges();
                //Index Sayfasına yönlendirir
                return RedirectToAction("Index");
            }
            //Şartlar karşılanmıyor ise aynı sayfayı tekrar açar
            else
            {
                return View(); 
            }
        }
    }
}

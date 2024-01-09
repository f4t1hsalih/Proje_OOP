using Microsoft.AspNetCore.Mvc;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class ProductContreller : Controller
    {
        Context context= new Context();

        public IActionResult Index()
        {
            var values =context.Products.ToList();
            return View(values);
        }
    }
}

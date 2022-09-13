using Microsoft.AspNetCore.Mvc;

namespace NetCoreUnityIOC.Controllers
{
    public class CategoryController : Controller
    {
        // TODO : Category Controller içerisindeki CRUD operasyonları tamamlanacak.

        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NetCoreUnityIOC.Context;
using NetCoreUnityIOC.Models.Entities;
using NetCoreUnityIOC.Models.ViewModels;
using NetCoreUnityIOC.Repositories;
using System.Linq;

namespace NetCoreUnityIOC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository<Product> _productRepo;
        private readonly IRepository<Category> _categoryRepo;
        private readonly IRepository<Supplier> _supplierRepo;
        private readonly ProjectContext _projectContext;

        public ProductController(IRepository<Product> productRepo, IRepository<Category> categoryRepo, IRepository<Supplier> supplierRepo, ProjectContext projectContext)
        {
            _productRepo = productRepo;
            _categoryRepo = categoryRepo;
            _supplierRepo = supplierRepo;
            _projectContext = projectContext;
        }

        [HttpGet]
        public IActionResult Create()
        {
            //fake datalar eklendi
            //_categoryRepo.Add(new Category {Name = "Electronic" });
            //_categoryRepo.Save();
            //_supplierRepo.Add(new Supplier {CompanyName = "Xiaomi" });
            //_supplierRepo.Save();
            var model = new ProductCreateViewModel()
            {
                Categories = _categoryRepo.GetAll().Select(a => new SelectListItem
                {
                    Text = a.Name,
                    Value = a.Id.ToString()
                }).ToList(),
                Suppliers = _supplierRepo.GetAll().Select(x => new SelectListItem {
                    Text = x.CompanyName,
                    Value= x.Id.ToString()
                }).ToList(),
                Product = new Product()
            };
            //_categoryRepo.Add(new Category { Name = "Cameras" });
            //_categoryRepo.Save();
            //_supplierRepo.Add(new Supplier { CompanyName = "Kodak" });
            //_supplierRepo.Save();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            
            _productRepo.Add(product);
            int result = _productRepo.Save();

            if (result > 0)
            {
                return RedirectToAction("List");
            }

            return NotFound();
        }
        
        [HttpGet]
        public IActionResult List()
        {
            //var list = _projectContext.Products.ToList();
            var products = _productRepo.GetAll(); // => Include etmek daha sağlıklı kullanıma elverişlidir, fakat bu durumda arka planda loading triggerlarını devreye sokar, loading araştırması yapılsın..
            return View(products);
        }

        // TODO : Product Controller yarım kalan crud operasyonları tamamlanacak. 

    }
}

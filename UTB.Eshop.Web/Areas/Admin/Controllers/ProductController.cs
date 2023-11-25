using Microsoft.AspNetCore.Mvc;
using UTB.Eshop.Application.Abstraction;
using UTB.Eshop.Domain.Entities;
using UTB.Eshop.Infrastructure.Database;
using UTB.Eshop.Infrastructure.Identity.Enums;
using Microsoft.AspNetCore.Authorization;

namespace UTB.Eshop.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class ProductController : Controller
    {
        IProductAdminService _productService;
        public ProductController(IProductAdminService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            IList<Product> products = _productService.Select();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productService.Create(product);

                return RedirectToAction(nameof(ProductController.Index));
            }
            else
            {
                return View(product);
            }
        }


        public IActionResult Delete(int Id)
        {
            bool deleted = _productService.Delete(Id);

            if (deleted)
            {
                return RedirectToAction(nameof(ProductController.Index));
            }
            else
            {
                return NotFound();
            }
        }
    }
}

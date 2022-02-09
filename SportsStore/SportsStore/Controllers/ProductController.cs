using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepoitory repository;

        public ProductController(IProductRepoitory productRepoitory)
        {
            repository = productRepoitory;
        }

        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}
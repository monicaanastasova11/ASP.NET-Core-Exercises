using Fluffy.Contracts;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CatController : Controller
    {
        private ICatService catService;
        

        public CatController(ICatService catService)
        {

         
            this.catService = catService;
        }
        public IActionResult Index()
        {
            var cats = this.catService.GetAll();
            return View(cats);
        }

        public IActionResult Add()
        {

            return View();
        }
        public IActionResult Create(Cat CattobeCreated)
        {
            this.catService.Create(CattobeCreated);
            return RedirectToAction("Index"); 
        }
        public IActionResult Details (int id)
        {
            Cat cat = this.catService.GetCat(id);
          
            return View(cat);
        }
    }
}

using MachineTestAssignment2.Data;
using MachineTestAssignment2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachineTestAssignment2.Controllers
{
    public class CategoryController : Controller
    { 
        private ApplicationDbContext _dbContext ;

        public CategoryController(ApplicationDbContext dbContext) 
        {
        this._dbContext = dbContext;
        }

        public IActionResult ListCategory()
        {
           var data =  _dbContext.Categories.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            ModelState.Clear();
            return View("Add");
        }

        public IActionResult Update(int Id)
        {

        }
    }
}

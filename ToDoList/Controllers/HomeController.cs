using ToDoList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _dbContext;

        public HomeController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Home";

            var goals = _dbContext.Goals!.
                OrderByDescending(a => a.Id).
                ToList();
            return View(goals);
        }
    }
}

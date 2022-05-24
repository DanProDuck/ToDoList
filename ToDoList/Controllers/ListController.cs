using ToDoList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ToDoList.Controllers
{
    public class ListController : Controller
    {
        private readonly MyDbContext _dbContext;

        public ListController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index(int id)
        {
            var goal = _dbContext.Goals!.FirstOrDefault(a => a.Id == id);
            return View(goal);
        }

        [HttpPost]
        public IActionResult Add(Goal goal, List <int> tags)
        {
            goal.CreationDate = DateTime.Now;
            var goalTags = _dbContext.Tags!.Where(t => tags.Contains(t.Id)).ToList();
            goal.Tags = goalTags;

            _dbContext.Goals!.Add(goal);
            _dbContext.SaveChanges();

            return View("Added", goal);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HobbyController : Controller
    {
        private Repository<Category> categories { get; set; }
        private Repository<Hobby> hobbies { get; set; }

        public HobbyController(BiographyContext ctx) {
            categories = new Repository<Category>(ctx);
            hobbies = new Repository<Hobby>(ctx);
        }

        public ViewResult Index(int id)
        {
            var categoryOptions = new QueryOptions<Category> { 
                OrderBy = c => c.CategoryId
            };

            var hobbyOptions = new QueryOptions<Hobby> {
                Includes = "Category, Person"
            };
            if (id == 0) {
                hobbyOptions.OrderBy = h => h.HobbyId;
            }
            else {
                hobbyOptions.Where = h => h.CategoryId == id;
            }

            // execute queries
            ViewBag.Days = categories.List(categoryOptions);
            return View(hobbies.List(hobbyOptions));
        }
    }
}

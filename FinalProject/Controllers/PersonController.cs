using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class PersonController : Controller
    {
        private Repository<Person> people { get; set; }
        public PersonController(BiographyContext ctx) => people = new Repository<Person>(ctx);

        public ViewResult Index()
        {
            var options = new QueryOptions<Person> {
                OrderBy = p => p.LastName
            };
            return View(people.List(options));
        }
    }
}
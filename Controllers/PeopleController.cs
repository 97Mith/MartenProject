using Microsoft.AspNetCore.Mvc;
using WebApp.Data;

namespace WebApp.Controllers
{
    

    public class PeopleController : Controller
    {
        private readonly PersonRepository _personRepository;

        public PeopleController(AppDbContext context)
        {
            _personRepository = new PersonRepository(context);
        }

        public IActionResult Index()
        {
            var people = _personRepository.GetAllPeople();
            return View(people);
        }
    }

}

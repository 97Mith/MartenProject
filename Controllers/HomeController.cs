using Marten;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Repository;


namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult ListPage(Person person)
        {
            return View(person);
        }
        [HttpPost("/create-person")]
        public async Task<IActionResult> CreatePerson([FromForm] Person person, [FromServices] IDocumentSession session)
        {
            session.Store(person);
            await session.SaveChangesAsync();
            return Redirect("/");
        }
        
        private readonly IRepository _repository = new Repository.Repository();

        
        public ActionResult ListPage()
        {
            var people = _repository.All();
            return View(people);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using postgresql.Data;
using postgresql.Models;
using System.Diagnostics;

namespace postgresql.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AppDbContext _DbContext;
        public HomeController(ILogger<HomeController> logger, AppDbContext bContext)
        {
            _logger = logger;
            _DbContext = bContext;
        }

        public IActionResult Index()
        {
            _DbContext.Users.Add(new User
            {
                Name = "soheil",
                lastnem = DateTime.Now.ToString()
            });




            //SELECT * FROM "Users";

            //  NuGet Packages
            //Npgsql.EntityFrameworkCore.PostgreSQL

            //Microsoft.EntityFrameworkCore
            //Microsoft.EntityFrameworkCore.Design
            //Microsoft.EntityFrameworkCore.Tools




            _DbContext.SaveChanges();
            List<User> obj = _DbContext.Users.ToList();
            return View(obj);
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
    }
}

using Ideal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ideal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IEnumerable<string> GetSessionInfo()
        {
            List<string> sessionInfo = new List<string>();
            
            //Set SessionVariable
            HttpContext.Session.SetString("UserName", "Tipu");

            //Get SessionVariable
            var UserName = HttpContext.Session.GetString("UserName");

            if(UserName != null)
            {
                sessionInfo.Add(UserName);
            }

            return sessionInfo;
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
    }
}
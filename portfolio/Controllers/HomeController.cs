using Microsoft.AspNetCore.Mvc;
using portfolio.Controllers.VM;
using portfolio.Data;
using portfolio.Models;
using System.Diagnostics;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly portfolioContext _context;

        public HomeController(portfolioContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context= context;
        }

        public IActionResult Index()
        {
            HomepageVM vm = new HomepageVM();
            vm.PersonalInfo = new PersonalInfo();
            vm.PersonalInfo = _context.PersonalInfo.FirstOrDefault();
            vm.MyExpertises = _context.MyExpertise.ToList();
            vm.Educations = _context.Education.ToList();
            return View(vm);
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
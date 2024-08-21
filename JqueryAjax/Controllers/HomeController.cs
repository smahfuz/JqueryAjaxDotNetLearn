using JqueryAjax.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JqueryAjax.Controllers
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

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public CalculateData CalculateNumber(int num1, int num2, string msgs)
        {
            var calculateNumber = new CalculateData();
            if (num1==0 || num2==0)
            {
                calculateNumber.Multiply = num1 * num2;
                calculateNumber.Add = num1 + num2;
                calculateNumber.Substruct = num1 - num2;
                calculateNumber.Division = 0;

            }
            else
            {
                calculateNumber.Multiply = num1 * num2;
                calculateNumber.Add = num1 + num2;
                calculateNumber.Substruct = num1 - num2;
                calculateNumber.Division = num1 / num2;

            }
           
            
            return calculateNumber;

        }
    }
}

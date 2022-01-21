using ExempleUnitTest;
using Microsoft.AspNetCore.Mvc;

namespace HelloTest.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int Ch1, int Ch2)
        {
            Operations op = new Operations(Ch1,Ch2);
            ViewBag.resultat = $"Le résultat de l'addition = {op.Addition()}";

            return View();
        }
    }
}

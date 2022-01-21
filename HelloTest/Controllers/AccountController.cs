using HelloTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloTest.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMySession _mySession;
        public AccountController(IMySession mySession)
        {
            _mySession = mySession;
        }
        public IActionResult Login()
        {
            _mySession.IsLogged = true;
            return View();
        }
    }
}

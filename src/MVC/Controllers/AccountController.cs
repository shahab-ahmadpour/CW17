using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC._Data;
using MVC.Repository;
using MVC.Services;
using System.Security.Claims;

namespace MVC.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserService _userService;

        public AccountController()
        {
            var dbContext = new ApplicationDbContext();
            var userRepository = new UserRepository(dbContext);
            _userService = new UserService(userRepository);
        }

        public IActionResult LoginOrRegister()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            try
            {
                _userService.RegisterUser(username, password);
                TempData["Message"] = "Registration successful! Please log in.";
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            try
            {
                var user = _userService.Login(username, password);

                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Username)
        };

                var identity = new ClaimsIdentity(claims, "Cookies");
                var principal = new ClaimsPrincipal(identity);

                HttpContext.SignInAsync("Cookies", principal).Wait();

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme).Wait();
            HttpContext.Session.Clear();
            return RedirectToAction("LoginOrRegister", "Account");
        }

    }
}

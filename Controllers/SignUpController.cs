using FlouristStudio.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlouristStudio.Controllers3
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(string Name,string UserName,string Email,string Password,string ConfirmPassword)
        {
            SignUp s = new(Name, UserName, Email, Password,ConfirmPassword);
            if (ModelState.IsValid)
            {
                DataBase.RegisterNewUser(s);
                return View();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Please enter correct data");
                return View("SignUpError");
            }
        }
        [HttpPost]
        public IActionResult SignIn(string UserName)
        {
            if (ModelState.IsValid)
            {
                return View("SignIn");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Please enter correct data");
                return View("SignUp");
            }
        }
    }
}

using AS1.Data;
using AS1.Models;
using AS1.Models.UserModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.ComponentModel.DataAnnotations;

namespace AS1.Controllers
{
    public class AccountController : Controller
    {
        public Assignment1DbContext Context { get; }
        private readonly IHttpContextAccessor _httpContextAccessor;


        public AccountController(Assignment1DbContext context, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        private string GetUsernameFromCookie()
        {
            var cookie = _httpContextAccessor.HttpContext.Request.Cookies["userName"];
            return cookie;
        }
        private void SetUsernameToCookie(string email)
        {
            var options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(1),
                Path = "/"
            };

            var name = email?.Split('@')[0];

            _httpContextAccessor.HttpContext.Response.Cookies.Append("userName", name, options);
        }


        public IActionResult Home()
        {
            var name = GetUsernameFromCookie();

            if (name != null)
            {
                return RedirectToAction("Member");

            }

            var signUpViewModel = new SignupViewModel();
            var signInViewModel = new SigninViewModel();
            var homeViewModel = new HomeViewModel()
            {
                SigninViewModel = signInViewModel,
                SignupViewModel = signUpViewModel
            };
            return View(homeViewModel);

        }

        [HttpPost]
        public IActionResult SignUp(SignupViewModel signupViewModel)
        {
            if (ModelState.IsValid)
            {
                if(Context.Users.Any(u => u.Email == signupViewModel.Email))
                {
                    //ModelState.AddModelError("", "Sorry... the email has been registered");
                    TempData["error"] = "Sorry..The Email has been registered..";
                    return View("Home", new HomeViewModel
                    {
                        SignupViewModel = signupViewModel,
                        SigninViewModel = new SigninViewModel()
                    });
                }

                var user = new User()
                {
                    Email = signupViewModel.Email,
                    Password = signupViewModel.Password,
                };
                Context.Users.Add(user);
                Context.SaveChanges();
                TempData["success"] = "Thanks! You are our member now, Please Signin to set the cookies and see our warm welcome!";

                return RedirectToAction("Home");

            }

            TempData["error"] = "Invalid input!!";
            return View("Home", new HomeViewModel()
            {
                SignupViewModel = signupViewModel,
                SigninViewModel = new SigninViewModel()
            });
        }

        [HttpPost]
        public IActionResult SignIn(SigninViewModel signinViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = Context.Users.FirstOrDefault(u => u.Email == signinViewModel.Email && u.Password == signinViewModel.Password);

                if(user == null)
                {
                    TempData["error"] = "Email or Password has something wrong...";
                    return View("Home", new HomeViewModel()
                    {
                        SigninViewModel = signinViewModel,
                        SignupViewModel = new SignupViewModel()
                    });
                }

                SetUsernameToCookie(signinViewModel.Email);
                TempData["success"] = "Welcome!";
                return RedirectToAction("Member");
            }
            TempData["error"] = "Input Invalid!";
            return View("Home", new HomeViewModel()
            {
                SigninViewModel = signinViewModel,
                SignupViewModel = new SignupViewModel()
            });
        }

        [HttpGet]
        public IActionResult Member()
        {
            
            var name = GetUsernameFromCookie();
            if (name != null)
            {
                ViewBag.WelcomeMessage = $"Welcome, {name}!";
                return View();
            }

            TempData["error"] = "Please Sign In first!";
            return RedirectToAction("Home");

        }

        [HttpGet]
        public IActionResult Logout()
        {
            // Remove the "userName" cookie
            _httpContextAccessor.HttpContext.Response.Cookies.Delete("userName");

            // Redirect to the home page
            return RedirectToAction("Home");
        }

    }
}

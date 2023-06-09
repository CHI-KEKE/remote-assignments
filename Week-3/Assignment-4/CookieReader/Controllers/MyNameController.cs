using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace CookieReader.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyNameController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MyNameController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        [Route("/myName")]
        public IActionResult GetMyName() 
        {
            var name = GetUsernameFromCookie();
            if(name == null)
            {
                var html = GetHtmlForm();
                return Content(html, "text/html");
            }

            return Content($"Hey! {name}","text/html");
        }

        [HttpPost]
        [Route("/trackName")]
        public IActionResult TrackName([FromForm] string name)
        {
            SetUsernameToCookie(name);
            return Redirect("/myName");
        }


        private string GetUsernameFromCookie()
        {
            var cookie = _httpContextAccessor.HttpContext.Request.Cookies["userName"];
            return cookie;
        }

        private void SetUsernameToCookie(string name)
        {
            var options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(1),
                Path = "/myName"
            };

            _httpContextAccessor.HttpContext.Response.Cookies.Append("userName", name, options);
        }
        private string GetHtmlForm()
        {
            var wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            var htmlFilePath = Path.Combine(wwwRootPath, "MyNameForm.html");

            var html = System.IO.File.ReadAllText(htmlFilePath);

            return html;
        }
    }
}
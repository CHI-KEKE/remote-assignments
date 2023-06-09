using Microsoft.AspNetCore.Mvc;
using System.IO;


namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FirstWebAPIController : ControllerBase
{
    private readonly ILogger<FirstWebAPIController> _logger;

    public FirstWebAPIController(ILogger<FirstWebAPIController> logger)
    {
        _logger = logger;

    }

    //[HttpGet("sum.html")]
    //public IActionResult GetHtmlFile()
    //{
    //    var htmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "sum.html");
    //    return PhysicalFile(htmlFilePath, "text/html");

    //}

    [HttpGet]
    public IActionResult Get(string? number)
    {
        if (number == null)
        {
            return Content("Lack of Parameter");
        }
        else if (!int.TryParse(number.ToString(), out int n))
        {
            return Content("Wrong Parameter");
        }
        int result = CheckSum(int.Parse(number));
        return Content(result.ToString());
    }
    private int CheckSum(int n)
    {
        //to avoid computationally expensive situation, we use pure math instead of loop through it
        return n * (n + 1) / 2;
    }




}

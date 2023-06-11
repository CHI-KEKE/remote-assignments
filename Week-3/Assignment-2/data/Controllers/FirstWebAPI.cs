using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class dataController : ControllerBase
{

    private readonly ILogger<dataController> _logger;

    public dataController(ILogger<dataController> logger)
    {
        _logger = logger;
    }

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
        else if (int.Parse(number) < 0)
        {
            return Content("Negative numbers are not allowed");
        }

        return Content(CheckSum(int.Parse(number)).ToString());

    }

    private int CheckSum(int n)
    {
        //to avoid computationally expensive situation, we use pure math instead of loop through it
        return n * (n + 1) / 2;
    }


}
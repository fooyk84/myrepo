using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using workshop01.Models;

namespace workshop01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] msg = new string[5];

        msg[0] = "Logic will get you from A to B. Imagination will take you everywhere.";
        msg[1] = "There are 10 kinds of people. Those who know binary and those who don't.";
        msg[2] = "There are two ways of constructing a software design. One way is to make it so simple that there are obviously no deficiencies and the other is to make it so complicated that there are no obvious deficiencies.";
        msg[3] = "It's not that I'm so smart, it's just that I stay with problems longer.";
        msg[4] = "It is pitch dark. You are likely to be eaten by a grue.";

        var randomGenerator = new Random();
        int num = randomGenerator.Next(0, 4);

        ViewBag.Message = msg[num];

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

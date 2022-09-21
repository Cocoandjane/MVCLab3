using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCLab3.Models;

namespace MVCLab3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.name="Lijuan liang";
        ViewBag.studentId="A01172330";
        ViewData["job"]= "When I graduate, I want to find a web dev job, I don't mind it is front end or back end or full stack. one thing for sue, I would pursue on database after graduation.";
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
}

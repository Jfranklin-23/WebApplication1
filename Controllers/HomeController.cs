using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        Name FullName = new Name ()
        {
            FirstName = "John Franklin",
            MiddleName = "Perez",
            LastName = "Nieras",
            Age = 22
        };
        return View(FullName);
    }

    public IActionResult Privacy()
    {
        return View();
    }

}

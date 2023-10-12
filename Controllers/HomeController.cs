using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SeriesEnHome.Models;

namespace SeriesEnHome.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Actores = BD.ObtenerActores();
        ViewBag.Series = BD.ObtenerSeries();
        ViewBag.Temporadas = BD.ObtenerTemporadas();
        return View();
    }
/*
    public Series traerSeries()
    {
        
         
    }

    public Series traerTemporadas()
    {
         
    }

    public Series traerActores()
    {
         
    }
*/

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

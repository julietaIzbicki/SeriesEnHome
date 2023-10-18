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
        
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }

    public List<Temporadas> traerTemporadas(int id)
    {
        return BD.ObtenerTemporadas(id);
    }

    public List<Actores> traerActores(int id)
    {
        return BD.ObtenerActores(id);
    }

    public string traerInfo(int id)
    {
        Series info = BD.ObtenerSerie(id);
        return info.Sinopsis;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

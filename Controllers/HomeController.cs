using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PodsFifAndChef.Models;

namespace PodsFifAndChef.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult IniciarSesion(string email, string contraseña)
    {
        Integrante integranteIngresado = BD.BuscarIntegrante(email, contraseña);
        if(integranteIngresado != null)
        {
            return View("DatosDelHombre");
        } else {
            return View("UsuarioNoEncontrado");
        }
    }

}
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    public class VeterinarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

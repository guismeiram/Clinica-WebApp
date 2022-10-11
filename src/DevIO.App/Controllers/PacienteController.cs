using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class PacienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

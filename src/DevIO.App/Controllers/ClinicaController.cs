using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class ClinicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

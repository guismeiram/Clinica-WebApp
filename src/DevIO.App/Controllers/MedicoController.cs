using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class MedicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

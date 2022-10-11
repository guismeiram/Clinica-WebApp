using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class ConvenioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

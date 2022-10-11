using DevIO.Bussines.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class ConvenioController : BaseController
    {
        public ConvenioController(INotificador notificador) : base(notificador)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

using DevIO.Bussines.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class ConsultaController : BaseController
    {
        public ConsultaController(INotificador notificador) : base(notificador)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

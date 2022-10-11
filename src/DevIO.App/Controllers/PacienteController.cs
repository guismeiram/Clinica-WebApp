using DevIO.Bussines.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class PacienteController : BaseController
    {
        public PacienteController(INotificador notificador) : base(notificador)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

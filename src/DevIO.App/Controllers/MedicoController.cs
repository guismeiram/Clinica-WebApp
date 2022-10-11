using DevIO.Bussines.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class MedicoController : BaseController
    {
        public MedicoController(INotificador notificador) : base(notificador)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

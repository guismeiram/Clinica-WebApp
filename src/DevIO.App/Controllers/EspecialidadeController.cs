using DevIO.Bussines.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class EspecialidadeController : BaseController
    {
        public EspecialidadeController(INotificador notificador) : base(notificador)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

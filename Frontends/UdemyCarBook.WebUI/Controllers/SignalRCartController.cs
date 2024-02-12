using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Controllers
{
    public class SignalRCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

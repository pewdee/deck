using Microsoft.AspNetCore.Mvc;

namespace Deck.Ui.Controllers
{
    public class MainController : Controller
    {
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
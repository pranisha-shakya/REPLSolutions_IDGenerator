using Microsoft.AspNetCore.Mvc;

namespace REPLSolutions_IDGenerator.Controllers
{
    public class LanyardController : Controller
    {
        public IActionResult Lanyard()
        {
            return View();
        }
    }
}

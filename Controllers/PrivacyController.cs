using Microsoft.AspNetCore.Mvc;

namespace HireHub.Controllers
{
    public class PrivacyController : Controller
    {
        // GET: /Privacy
        public IActionResult Index()
        {
            return View();
        }
    }
}
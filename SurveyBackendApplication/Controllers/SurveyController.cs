using Microsoft.AspNetCore.Mvc;

namespace SurveyBackendApplication.Controllers
{
    public class SurveyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

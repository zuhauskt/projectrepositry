using Microsoft.AspNetCore.Mvc;

namespace Clinic_Management_System.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
       
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BercaCafe_Client.TempController
{
    public class DashboardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

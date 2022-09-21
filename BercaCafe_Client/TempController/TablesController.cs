using Microsoft.AspNetCore.Mvc;

namespace BercaCafe_Client.TempController
{
    public class TablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

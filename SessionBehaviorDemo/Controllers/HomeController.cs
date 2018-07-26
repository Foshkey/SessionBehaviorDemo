using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SessionBehaviorDemo.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("TestKey", "TestValue");
            return View();
        }
    }
}

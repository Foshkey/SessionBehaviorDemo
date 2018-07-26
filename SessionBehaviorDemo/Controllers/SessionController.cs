using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace SessionBehaviorDemo.Controllers {
    public class SessionController : Controller {
        public IActionResult Short() {
            HttpContext.Session.GetString("TestKey"); // Load up session
            Thread.Sleep(1000);
            HttpContext.Session.SetString("ShortCallKey", "ShortTestValue");
            return Ok("Short Completed");
        }
        public IActionResult Long() {
            HttpContext.Session.GetString("TestKey"); // Load up session
            Thread.Sleep(5000);
            HttpContext.Session.SetString("LongCallKey", "LongTestValue");
            return Ok("Long Completed");
        }
        public IActionResult List() {
            string result = "";
            foreach(var key in HttpContext.Session.Keys) {
                result += $"<p>{key}: {HttpContext.Session.GetString(key)}</p>";
            }
            return Ok(result);
        }
    }
}

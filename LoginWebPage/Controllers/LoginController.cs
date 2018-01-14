using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginWebPage.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // POST: /Login
        [HttpPost]
        public ActionResult Login()
        {
            throw new NotImplementedException();
        }
    }
}

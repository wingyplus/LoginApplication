using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

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
        public ActionResult DoLogin(string username, string password)
        {
            try
            {
                ValidateUsername(username);
                ValidatePassword(password);
            }
            catch (Exception e)
            {
                return RedirectToAction("LoginFail", new AuthenticationError(e.Message));
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult LoginFail(string EMessage)
        {
            ViewBag.Message = EMessage;
            return View();
        }

        private static void ValidatePassword(string password)
        {
            if (password != "sa")
            {
                throw new Exception("Password not matched");
            }
        }

        private static void ValidateUsername(string username)
        {
            if (username != "jacksw")
            {
                throw new Exception("Username not matched");
            }
        }
    }
}

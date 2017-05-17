using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lesson3.DAL;

namespace lesson3.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        private AccountContext db = new AccountContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.LoginState = "登陆前。。。";
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string email = fc["inputEmail"];
            string password = fc["inputPassword"];
            //ViewBag.LoginState = email + "登陆后。。。";
            var user = db.SysUsers.Where(b => b.Email == email & b.Password == password);
            if (user.Count() > 0)
            {
                ViewBag.LoginState = email + "登录后。。。";
            }
            else
            {
                ViewBag.LoginState = email + "用户不存在。。。";
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
	}
}
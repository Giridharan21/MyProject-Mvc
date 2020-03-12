using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;
using DataAccessLayer.Models;

namespace HomeServices.Controllers
{
    public class AuthenticateController : Controller
    {
        // GET: Authenticate
        public ActionResult Login()
        {

            return View();
        }
        
        public ActionResult Register()
        {
            RegisterModel UserModel = new RegisterModel();
            UserModel.Type = new DropDownListClass();
            UserModel.Type.TypeOfUser = new SelectList(new List<string> { "Customer", "Service Provider" });
            return View(UserModel);
        }

        [HttpPost]
        public ActionResult Register(RegisterModel User) {
            User.Type = new DropDownListClass();
            User.Type.TypeOfUser = new SelectList(new List<string> { "Customer", "Service Provider" });
            return RedirectToAction("Login","Authenticate");
        }
    }
}
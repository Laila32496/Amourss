using Amourss.Models.Common;
using Amourss.Models.DBModels;
using Amourss.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amourss.Controllers
{
    public class AccountController : BaseController
    {
        public UserRepository UserRepo { get; set; }
        public SettingRepository SettingRepo { get; set; }
        public Setting st { get; set; }
        public AccountController()
        {
            this.UserRepo = new UserRepository();
            this.SettingRepo = new SettingRepository();
            try
            {
                this.st = SettingRepo.GetList().First();
                ViewBag.Layout = this.st;
            }
            catch (Exception ex)
            {
                ViewBag.Layout = new Setting();
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            SessionUser user = new SessionUser(UserRepo.Get(Email, Password));
            if (user != null && user.ID != 0)
            {
                Session["User"] = user;
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}
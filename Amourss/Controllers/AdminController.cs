using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amourss.Controllers
{
    public class AdminController : PanelController
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}
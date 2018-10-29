using Amourss.Models.DBModels;
using Amourss.Models.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amourss.Controllers
{
    public class HomePageVideoController : PanelController
    {
        public HomePageVideoRepository HomePageVideoRepo { get; set; }
        public HomePageVideoController()
        {
            HomePageVideoRepo = new HomePageVideoRepository();
        }
        public ActionResult Index()
        {
            List<HomePageVideo> HomePageVideoList = HomePageVideoRepo.GetList();
            return View(HomePageVideoList);
        }

        public ActionResult AddHomePageVideo(HomePageVideo HomePageVideo)
        {
            if (HomePageVideoRepo.Insert(HomePageVideo))
            {
                Notify("Success", "Successfully added", "Product Added Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to add product due to technical issues", false, false, true);
            }

            return RedirectToAction("Index", "HomePageVideo");
        }

        public ActionResult Delete(int HomePageVideoID)
        {
            if (HomePageVideoRepo.Delete(HomePageVideoID))
            {
                Notify("Success", "Successfully Deleted", "Product Deleted Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to Delete product due to technical issues", false, false, true);
            }
            return RedirectToAction("Index", "HomePageVideo");
        }
    }
}
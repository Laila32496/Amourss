using Amourss.Models.Common;
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
    public class WhyUsController : PanelController
    {
        public WhyUsRepository WhyUsRepo { get; set; }
        public WhyUsController()
        {
            WhyUsRepo = new WhyUsRepository();
        }
        public ActionResult Index()
        {
            List<WhyUs> WhyUsList = WhyUsRepo.GetList();
            return View(WhyUsList);
        }

        public ActionResult AddWhyUs(WhyUs WhyUs, HttpPostedFileBase ImageFile)
        {
            if (ImageFile != null)
            {

                string fn = Path.GetFileName(ImageFile.FileName);
                string fileExtension = fn.Remove(0, fn.IndexOf('.') + 1);
                fn = Common.SafeSubstring(WhyUs.Title, 0, 5)  + "." + Common.RandomString(5) + "." + fileExtension;
                string SaveLocation = "~/Images/WhyUs/";
                WhyUs.ImagePath = Path.Combine(SaveLocation, fn);
                string FilePath = Server.MapPath(SaveLocation);
                ImageFile.SaveAs(Path.Combine(FilePath, fn));
            }

            if (WhyUsRepo.Insert(WhyUs))
            {
                Notify("Success", "Successfully added", "Product Added Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to add product due to technical issues", false, false, true);
            }

            return RedirectToAction("Index", "WhyUs");
        }

        public ActionResult Delete(int WhyUsID)
        {
            if (WhyUsRepo.Delete(WhyUsID))
            {
                Notify("Success", "Successfully Deleted", "Product Deleted Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to Delete product due to technical issues", false, false, true);
            }
            return RedirectToAction("Index", "WhyUs");
        }
    }
}
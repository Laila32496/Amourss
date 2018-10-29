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
    public class HelpOptionController : PanelController
    {
        public HelpOptionRepository HelpOptionRepo { get; set; }
        public HelpOptionController()
        {
            HelpOptionRepo = new HelpOptionRepository();
        }
        public ActionResult Index()
        {
            List<HelpOption> HelpOptionList = HelpOptionRepo.GetList();
            return View(HelpOptionList);
        }

        public ActionResult AddHelpOption(HelpOption HelpOption, HttpPostedFileBase ImageFile)
        {
            if (ImageFile != null)
            {

                string fn = Path.GetFileName(ImageFile.FileName);
                string fileExtension = fn.Remove(0, fn.IndexOf('.') + 1);
                fn = Common.SafeSubstring(HelpOption.Title, 0, 5) +"."+  Common.RandomString(5) + "." + fileExtension;
                string SaveLocation = "~/Images/HelpOptions/";
                HelpOption.ImagePath = Path.Combine(SaveLocation, fn);
                string FilePath = Server.MapPath(SaveLocation);
                ImageFile.SaveAs(Path.Combine(FilePath, fn));
            }

            if (HelpOptionRepo.Insert(HelpOption))
            {
                Notify("Success", "Successfully added", "Help Option Added Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to add Help Option due to technical issues", false, false, true);
            }

            return RedirectToAction("Index", "HelpOption");
        }

      

        public ActionResult Delete(int HelpOptionID)
        {
            if (HelpOptionRepo.Delete(HelpOptionID))
            {
                Notify("Success", "Successfully Deleted", "Help Option Deleted Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to Delete Help Option due to technical issues", false, false, true);
            }
            return RedirectToAction("Index", "HelpOption");
        }
    }
}
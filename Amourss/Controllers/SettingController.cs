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
    public class SettingController : PanelController
    {
        public SettingRepository SettingRepo { get; set; }
        public SettingController()
        {
            SettingRepo = new SettingRepository();
        }
        public ActionResult Index()
        {
            Setting setting = new Setting();
            try
            {
               setting =  SettingRepo.GetList().First();
            }
            catch (Exception ex)
            {

            }
            return View(setting);
        }

        public ActionResult AddSetting(Setting Setting, HttpPostedFileBase DarkLogo, HttpPostedFileBase LightLogo)
        {
            if (LightLogo != null)
            {

                string fn = Path.GetFileName(LightLogo.FileName);
                string fileExtension = fn.Remove(0, fn.IndexOf('.') + 1);
                fn = "LightLogo." + fileExtension;
                string SaveLocation = "~/Images/Setting/";
                Setting.LightLogoImage = Path.Combine(SaveLocation, fn);
                string FilePath = Server.MapPath(SaveLocation);
                LightLogo.SaveAs(Path.Combine(FilePath, fn));
            }
            if (DarkLogo != null)
            {

                string fn = Path.GetFileName(DarkLogo.FileName);
                string fileExtension = fn.Remove(0, fn.IndexOf('.') + 1);
                fn = "DarkLogo." + fileExtension;
                string SaveLocation = "~/Images/Setting/";
                Setting.DarkLogoImage = Path.Combine(SaveLocation, fn);
                string FilePath = Server.MapPath(SaveLocation);
                DarkLogo.SaveAs(Path.Combine(FilePath, fn));
            }
            if (Setting.ID != 0)
            {
                if (SettingRepo.Update(Setting))
                {
                    Notify("Success", "Successfully Saved", "Settings Saved Successfully", false, false, true);
                }
                else
                {
                    Notify("Error", "Technical Error", "Unable to Save Settings due to technical issues", false, false, true);
                }
            }
            else 
            {
                if (SettingRepo.Insert(Setting))
                {
                    Notify("Success", "Successfully Saved", "Settings Saved Successfully", false, false, true);
                }
                else
                {
                    Notify("Error", "Technical Error", "Unable to settings due to technical issues", false, false, true);
                }
            }


            return RedirectToAction("Index", "Setting");
        }

        public ActionResult Delete(int SettingID)
        {
            if (SettingRepo.Delete(SettingID))
            {
                Notify("Success", "Successfully Deleted", "Product Deleted Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to Delete product due to technical issues", false, false, true);
            }
            return RedirectToAction("Index", "Setting");
        }
    }
}
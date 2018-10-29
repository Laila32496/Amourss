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
    public class CauseController : PanelController
    {
        public CauseRepository CauseRepo { get; set; }
        public CauseController()
        {
            CauseRepo = new CauseRepository();
        }
        public ActionResult Index()
        {
            List<Cause> CauseList = CauseRepo.GetList();
            return View(CauseList);
        }


        [HttpGet]
        public ActionResult AddCause(int CauseID = 0)
        {
            Cause cause = new Cause();
            if (CauseID != 0)
            { 
                cause = CauseRepo.Get(CauseID);
            }
            return View(cause);
        }


        [HttpPost]
        public ActionResult AddCause(Cause cause, HttpPostedFileBase ImageFile)
        {
            if (ImageFile != null)
            {

                string fn = Path.GetFileName(ImageFile.FileName);
                string fileExtension = fn.Remove(0, fn.IndexOf('.') + 1);
                fn =  "Cause-" +  Common.RandomString(5) +  "." + fileExtension;
                string SaveLocation = "~/Images/Causes/";
                cause.ImagePath = Path.Combine(SaveLocation, fn);
                string FilePath = Server.MapPath(SaveLocation);
                ImageFile.SaveAs(Path.Combine(FilePath, fn));
            }

            if (cause.ID == 0)
            {
                if (CauseRepo.Insert(cause))
                {
                    Notify("Success", "Successfully added", "Product Added Successfully", false, false, true);
                }
                else
                {
                    Notify("Error", "Technical Error", "Unable to add product due to technical issues", false, false, true);
                }
            }
            else
            {
                if (CauseRepo.Update(cause))
                {
                    Notify("Success", "Successfully added", "Product Added Successfully", false, false, true);
                }
                else
                {
                    Notify("Error", "Technical Error", "Unable to add product due to technical issues", false, false, true);
                }
            }
            return RedirectToAction("Index", "Cause");
        }

        public ActionResult Delete(int CauseID)
        {
            if (CauseRepo.Delete(CauseID))
            {
                Notify("Success", "Successfully Deleted", "Product Deleted Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to Delete product due to technical issues", false, false, true);
            }
            return RedirectToAction("Index", "Cause");
        }
    }
}
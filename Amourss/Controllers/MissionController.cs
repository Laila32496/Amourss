﻿using Amourss.Models.Common;
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
    public class MissionController : PanelController
    {
        public MissionRepository MissionRepo { get; set; }
        public MissionController()
        {
            MissionRepo = new MissionRepository();
        }
        public ActionResult Index()
        {
            List<Mission> MissionList = MissionRepo.GetList();
            return View(MissionList);
        }

        public ActionResult AddMission(Mission Mission, HttpPostedFileBase ImageFile)
        {
            if (ImageFile != null)
            {

                string fn = Path.GetFileName(ImageFile.FileName);
                string fileExtension = fn.Remove(0, fn.IndexOf('.') + 1);
                fn = Common.SafeSubstring(Mission.Title, 0, 5) + "." + Common.RandomString(5) + "." + fileExtension;
                string SaveLocation = "~/Images/Missions/";
                Mission.ImagePath = Path.Combine(SaveLocation, fn);
                string FilePath = Server.MapPath(SaveLocation);
                ImageFile.SaveAs(Path.Combine(FilePath, fn));
            }

            if (MissionRepo.Insert(Mission))
            {
                Notify("Success", "Successfully added", "Product Added Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to add product due to technical issues", false, false, true);
            }

            return RedirectToAction("Index", "Mission");
        }

        public ActionResult Delete(int MissionID)
        {
            if (MissionRepo.Delete(MissionID))
            {
                Notify("Success", "Successfully Deleted", "Product Deleted Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to Delete product due to technical issues", false, false, true);
            }
            return RedirectToAction("Index", "Mission");
        }
    }
}
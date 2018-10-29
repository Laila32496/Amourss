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
    public class UserController : PanelController
    {
        public UserRepository UserRepo { get; set; }
        public UserController()
        {
            UserRepo = new UserRepository();
        }
        public ActionResult Index()
        {
            List<User> UserList = UserRepo.GetList();
            return View(UserList);
        }

        public ActionResult AddUser(User User, HttpPostedFileBase ImageFile)
        {
            if (ImageFile != null)
            {

                string fn = Path.GetFileName(ImageFile.FileName);
                string fileExtension = fn.Remove(0, fn.IndexOf('.') + 1);
                fn = Common.SafeSubstring(User.FirstName + User.LastName , 0, 10) +  "." + Common.RandomString(5) + "." + fileExtension;
                string SaveLocation = "~/Images/Users/";
                User.ImagePath = Path.Combine(SaveLocation, fn);
                string FilePath = Server.MapPath(SaveLocation);
                ImageFile.SaveAs(Path.Combine(FilePath, fn));
            }

            if (UserRepo.Insert(User))
            {
                Notify("Success", "Successfully added", "Product Added Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to add product due to technical issues", false, false, true);
            }

            return RedirectToAction("Index", "User");
        }

        public ActionResult Delete(int UserID)
        {
            if (UserRepo.Delete(UserID))
            {
                Notify("Success", "Successfully Deleted", "Product Deleted Successfully", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to Delete product due to technical issues", false, false, true);
            }
            return RedirectToAction("Index", "User");
        }
    }
}
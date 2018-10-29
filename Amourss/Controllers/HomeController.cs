using Amourss.Models.DBModels;
using Amourss.Models.Repositories;
using Amourss.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amourss.Controllers
{
    public class HomeController : BaseController
    {

        public CauseRepository CauseRepo { get; set; }
        public HelpOptionRepository HelpOptionRepo { get; set; }
        public HomePageVideoRepository HomePageVideoRepo { get; set; }
        public MissionRepository MissionRepo { get; set; }
        public WhyUsRepository WhyUsRepo { get; set; }
        public ContactRepository ContactRepo { get; set; }
        public CardRepository CardRepo { get; set; }
        public SubscriptionRepository SubscriptionRepo { get; set; }


        public HomeController()
        {

            this.CardRepo = new CardRepository();
            this.CauseRepo = new CauseRepository();
            this.HelpOptionRepo = new HelpOptionRepository();
            this.HomePageVideoRepo = new HomePageVideoRepository();
            this.MissionRepo = new MissionRepository();
            this.WhyUsRepo = new WhyUsRepository();
            this.ContactRepo = new ContactRepository();
            this.SubscriptionRepo = new SubscriptionRepository();
           



        }


        public ActionResult Index()
        {
            HomePage_VM vm = GetHomage_VM();
            return View(vm);
        }
        [NonAction]
        public HomePage_VM GetHomage_VM()
        {
            HomePage_VM vm = new HomePage_VM();

            Setting st = new Setting();
            try
            {
                st = SettingRepo.GetList().First();
            }
            catch (Exception ex)
            {

            }
            vm.setting = st;
            List<Cause> CauseList = CauseRepo.GetList();
            vm.FeaturedCauses = CauseList.Where(x => x.Featured == 2).ToList();
            vm.FrontCauses = CauseList.Where(x => x.Featured == 1).ToList();
            vm.HelpOptions = HelpOptionRepo.GetList();
            vm.HomePageVideo = HomePageVideoRepo.GetList();
            vm.Missions = MissionRepo.GetList();
            vm.WhyUsList = WhyUsRepo.GetList();

            return vm;
        }


        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Contact contact)
        {
            if (ContactRepo.Insert(contact))
            {
                Notify("Success", "Successfully Savd", "your message has been successfully saved", false, false, true);
            }
            else
            {
                Notify("Error", "Technical Error", "Unable to save message due to technical error", false, false, true);
            }
            return RedirectToAction("Contact");
        }

        public ActionResult AboutUs()
        {
            return View(CauseRepo.GetList());
        }
        public ActionResult NewsAndUpdate()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View(CauseRepo.GetList());
        }


        public ActionResult Project()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Donate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Donate(CardDetails cardDetails )
        {

            CardRepo.Insert(cardDetails);
            ViewBag.Success = "Success";
            return View();
        }



        [HttpPost]
        public ActionResult NewsLetterSubscription(Subscription sub, string RedirectURL)
        {
            sub.IPAddress = Request.UserHostAddress;
            SubscriptionRepo.Insert(sub);

            TempData["NewsLetterSuccess"] = "Success";
            return Redirect(RedirectURL);

        }


    }
}
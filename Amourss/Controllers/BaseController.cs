using Amourss.Hubs;
using Amourss.Models.Common;
using Amourss.Models.DBModels;
using Amourss.Models.Repositories;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amourss.Controllers
{
    //[ErrorHandler]
    public class BaseController : Controller
    {
        protected IHubContext Context { get; set; }
        public SettingRepository SettingRepo { get; set; }
        public Setting st { get; set; }
        public BaseController()
        {
            this.SettingRepo = new SettingRepository();
            this.Context = GlobalHost.ConnectionManager.GetHubContext<Notification>();
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


        public void Notify(string Type, string Title, string Description, bool IsAjaxMessage = true, bool IsViewMessage = true, bool IsRedirectMessage = false)
        {
            Notify(new NotificationMessage
            {
                MessageType = Type,
                Title = Title,
                Description = Description,
                IsAjaxMessage = IsAjaxMessage,
                IsViewMessage = IsViewMessage,
                IsRedirectMessage = IsRedirectMessage
            });
        }

        public virtual void Notify(NotificationMessage message)
        {
            if (message.IsAjaxMessage)
            {
                Context.Clients.Group(Request.UserHostAddress).Notify(message);
            }
            if (message.IsRedirectMessage)
            {
                TempData["NotificationMessage"] = message;
            }
            if (message.IsViewMessage)
            {
                ViewBag.NotificationMessage = message;
            }
        }

        public new RedirectToRouteResult RedirectToAction(string action, string controller)
        {
            return base.RedirectToAction(action, controller);
        }
    }
}
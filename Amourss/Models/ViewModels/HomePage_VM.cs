using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.ViewModels
{
    public class HomePage_VM
    {
        //public string LightLogoImage { get; set; }
        //public string DarkLogoImage { get; set; }
        //public string Facebook { get; set; }
        //public string Twitter { get; set; }
        //public string GooglePlus { get; set; }
        //public string Instagram { get; set; }
        //public string LinkedIn { get; set; }
        //public string Vimeo { get; set; }
        //public string FooterDescription { get; set; }
        //public string Address { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }

        public Setting setting { get; set; }
        public List<Cause> FeaturedCauses { get; set; }
        public List<Cause> FrontCauses { get; set; }
        public List<HomePageVideo> HomePageVideo { get; set; }
        public List<HelpOption> HelpOptions { get; set; }
        public List<Mission> Missions { get; set;}
        public List<WhyUs> WhyUsList { get; set; }

    }
}
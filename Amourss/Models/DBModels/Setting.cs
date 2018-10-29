using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.DBModels
{
    [Table("HomePage")]
    public class Setting
    {
        [DontInsert]
        [DontUpdate]
        public int ID { get; set; }
        public string CompanyTitle { get; set; }
        public string LightLogoImage { get; set; }
        public string DarkLogoImage { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string GooglePlus { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }
        public string Vimeo { get; set; }
        public string FooterDescription { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public string Location { get; set; }
        public string CompanySubTitle { get; set; }
    }
}
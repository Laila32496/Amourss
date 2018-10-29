using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.DBModels
{
    public class HomePageVideo
    {
        [DontInsert]
        [DontUpdate]
        public int ID { get; set; }
        public string VideoLink { get; set; }
        public string VideoTitle { get; set; }
        public string VideoDescription { get; set; }
        [DontInsert]
        [DontUpdate]
        public DateTime TimeStamp { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.DBModels
{
    public class WhyUs
    {
        [DontInsert]
        [DontUpdate]
     
        public int ID { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DontInsert]
        [DontUpdate]
        public DateTime TimeStamp { get; set; }
    }
}
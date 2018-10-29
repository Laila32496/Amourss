using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.DBModels
{
    [Table("NewsLetterSubscription")]
    public class Subscription
    {
        [DontInsert]
        [DontUpdate]
        public int ID { get; set; }
        public string Email { get; set; }
        public string IPAddress { get; set; }
        [DontInsert]
        [DontUpdate]
        public DateTime TimeStamp { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.DBModels
{
    public class Contact
    {
        [DontInsert]
        [DontUpdate]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        [DontInsert]
        [DontUpdate]
        public DateTime TimeStamp { get; set; }
    }
}
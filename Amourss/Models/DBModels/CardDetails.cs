using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.DBModels
{
    public class CardDetails
    {
        [DontInsert]
        [DontUpdate]
        public int ID { get; set; }
        public string CardNumber { get; set; }
        public string Expires { get; set; }
        public string CVV { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Amount { get; set; }
    }
}
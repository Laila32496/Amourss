using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.DBModels
{
    [Table("Users")]
    public class User
    {
        [DontInsert]
        [DontUpdate]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string ImagePath { get; set; }
        [DontInsert]
        [DontUpdate]
        public DateTime TimeStamp { get; set; }

    }
}
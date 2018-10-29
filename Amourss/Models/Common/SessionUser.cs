using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Common
{
    public class SessionUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string MobileNo { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string AuthToken { get; set; }
        public string Type { get; set; }
        public int RoleID { get; set; }
        public string ImagePath { get; set; }


        public SessionUser(User user)
        {

            ID = user.ID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Type = "User";
            this.ImagePath = user.ImagePath;

        }

        public SessionUser()
        {

        }



    }
}
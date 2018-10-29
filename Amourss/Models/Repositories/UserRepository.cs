using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Repositories
{
    public class UserRepository : DBRepository
    {
        public User Get(string Email, string Password)
        {
            db.values.Add("@Email", Email);
            db.values.Add("@Password", Password);
            return DBHelper.Get<User>("","Where Email = @Email AND Password = @Password", db.values);
        }


        public bool Insert(User User)
        {
            return DBHelper.Insert(User);
        }
        public bool Update(User User)
        {
            db.values.Add("@ID", User.ID.ToString());
            return DBHelper.Update(User, "Where ID = @ID", db.values);

        }
        public bool Delete(int UserID)
        {
            db.values.Add("@ID", UserID.ToString());
            return DBHelper.Delete<User>("Where ID = @ID", db.values);
        }

        public List<User> GetList()
        {
            return DBHelper.GetList<User>();
        }


    }
}
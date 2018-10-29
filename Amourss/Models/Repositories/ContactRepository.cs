using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Repositories
{
    public class ContactRepository : DBRepository
    {
        public bool Insert(Contact Contact)
        {
            return DBHelper.Insert(Contact);
        }
        public bool Update(Contact Contact)
        {
            db.values.Add("@ID", Contact.ID.ToString());
            return DBHelper.Update(Contact, "Where ID = @ID", db.values);

        }
        public bool Delete(int ContactID)
        {
            db.values.Add("@ID", ContactID.ToString());
            return DBHelper.Delete<Contact>("Where ID = @ID", db.values);
        }

        public List<Contact> GetList()
        {
            return DBHelper.GetList<Contact>();
        }
    }
}
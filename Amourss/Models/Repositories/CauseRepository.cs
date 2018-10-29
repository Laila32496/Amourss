using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Repositories
{
    public class CauseRepository : DBRepository
    {
        public bool Insert(Cause cause)
        {
            return DBHelper.Insert(cause);
        }
        public bool Update(Cause cause)
        {
            db.values.Add("@ID", cause.ID.ToString());
            return DBHelper.Update(cause, "Where ID = @ID", db.values);

        }
        public bool Delete(int CauseID)
        {
            db.values.Add("@ID", CauseID.ToString());
            return DBHelper.Delete<Cause>("Where ID = @ID", db.values);
        }

        public List<Cause> GetList()
        {
            return DBHelper.GetList<Cause>();
        }

        public Cause Get(int CauseID)
        {
            db.values.Add("@ID", CauseID.ToString());
            return DBHelper.Get<Cause>("", "Where ID = @ID", db.values);
        }

    }
}
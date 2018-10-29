using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Repositories
{
    public class WhyUsRepository : DBRepository
    {
        public bool Insert(WhyUs WhyUs)
        {
            return DBHelper.Insert(WhyUs);
        }
        public bool Update(WhyUs WhyUs)
        {
            db.values.Add("@ID", WhyUs.ID.ToString());
            return DBHelper.Update(WhyUs, "Where ID = @ID", db.values);

        }
        public bool Delete(int WhyUsID)
        {
            db.values.Add("@ID", WhyUsID.ToString());
            return DBHelper.Delete<WhyUs>("Where ID = @ID", db.values);
        }

        public List<WhyUs> GetList()
        {
            return DBHelper.GetList<WhyUs>();
        }
    }
}
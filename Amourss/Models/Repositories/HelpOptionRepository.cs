using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Repositories
{
    public class HelpOptionRepository : DBRepository
    {
        public bool Insert(HelpOption HelpOption)
        {
            return DBHelper.Insert(HelpOption);
        }
        public bool Update(HelpOption HelpOption)
        {
            db.values.Add("@ID", HelpOption.ID.ToString());
            return DBHelper.Update(HelpOption, "Where ID = @ID", db.values);

        }
        public bool Delete(int HelpOptionID)
        {
            db.values.Add("@ID", HelpOptionID.ToString());
            return DBHelper.Delete<HelpOption>("Where ID = @ID", db.values);
        }

        public List<HelpOption> GetList()
        {
            return DBHelper.GetList<HelpOption>();
        }
    }
}
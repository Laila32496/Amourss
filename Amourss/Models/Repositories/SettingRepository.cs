using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Repositories
{
    public class SettingRepository : DBRepository
    {
        public bool Insert(Setting Setting)
        {
            return DBHelper.Insert(Setting);
        }
        public bool Update(Setting Setting)
        {
            return DBHelper.Update(Setting, "Where 1 = 1", null);
        }
        public bool Delete(int SettingID)
        {
            db.values.Add("@ID", SettingID.ToString());
            return DBHelper.Delete<Setting>("Where ID = @ID", db.values);
        }

        public List<Setting> GetList()
        {
            return DBHelper.GetList<Setting>();
        }
    }
}
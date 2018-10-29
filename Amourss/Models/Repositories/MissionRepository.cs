using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Repositories
{
    public class MissionRepository : DBRepository
    {
        public bool Insert(Mission Mission)
        {
            return DBHelper.Insert(Mission);
        }
        public bool Update(Mission Mission)
        {
            db.values.Add("@ID", Mission.ID.ToString());
            return DBHelper.Update(Mission, "Where ID = @ID", db.values);

        }
        public bool Delete(int MissionID)
        {
            db.values.Add("@ID", MissionID.ToString());
            return DBHelper.Delete<Mission>("Where ID = @ID", db.values);
        }

        public List<Mission> GetList()
        {
            return DBHelper.GetList<Mission>();
        }
    }
}
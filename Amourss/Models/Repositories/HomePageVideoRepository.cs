using Amourss.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Repositories
{
    public class HomePageVideoRepository : DBRepository
    {
        public bool Insert(HomePageVideo HomePageVideo)
        {
            return DBHelper.Insert(HomePageVideo);
        }
        public bool Update(HomePageVideo HomePageVideo)
        {
            db.values.Add("@ID", HomePageVideo.ID.ToString());
            return DBHelper.Update(HomePageVideo, "Where ID = @ID", db.values);

        }
        public bool Delete(int HomePageVideoID)
        {
            db.values.Add("@ID", HomePageVideoID.ToString());
            return DBHelper.Delete<HomePageVideo>("Where ID = @ID", db.values);
        }

        public List<HomePageVideo> GetList()
        {
            return DBHelper.GetList<HomePageVideo>();
        }
    }
}
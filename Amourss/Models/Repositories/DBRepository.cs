using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.Repositories
{
    public class DBRepository
    {
        public DBHelper db { get; set; }
        public DBRepository()
        {
            this.db = new DBHelper();
        }

        public virtual bool Insert<T>(T Object)
        {
            return DBHelper.Insert<T>(Object);
        }
        public virtual bool Update<T>(dynamic Object)
        {
            db.values.Add("@ID", Object.ID.ToString());
            return DBHelper.Update<T>(Object, "Where ID = @ID", db.values);
        }
        public virtual List<T> Getlist<T>()
        {
            return DBHelper.GetList<T>();
        }

        public virtual T Get<T>(int ID)
        {
            db.values.Add("@ID", ID.ToString());
            return DBHelper.Get<T>("","Where ID = @ID", db.values);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amourss.Models.DBModels
{
    public class Cause
    {
        [DontInsert]
        [DontUpdate]
        public int ID { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double EarningGoal { get; set; }
        public double AchievedGoal { get; set; }
        public int Featured { get; set; }
        [DontInsert]
        [DontUpdate]
        public DateTime TimeStamp { get; set; }
        public string TextColor { get; set; }
        public string TextStyle { get; set; }
    }
}
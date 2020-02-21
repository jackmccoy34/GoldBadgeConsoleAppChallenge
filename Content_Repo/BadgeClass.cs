using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Repo
{
    public class BadgeClass
    {
        public int BadgeID { get; set; }
        public string DoorName { get; set; }


        public BadgeClass(int badgeID, string doorName)
        {
            BadgeID = badgeID;
            DoorName = doorName; 
        }

    }
}

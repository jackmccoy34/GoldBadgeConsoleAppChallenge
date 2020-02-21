using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Repo
{
    public class BadgeRepo
    {

        private readonly Dictionary<int, List<string>> internalDictionary = new Dictionary<int, List<string>>();

        public void Add(int BadgeID, string DoorName)
        {
            if (this.internalDictionary.ContainsKey(BadgeID))
            {
                List<string> list = this.internalDictionary[BadgeID];
                if (list.Contains(DoorName) == false)
                {
                    list.Add(DoorName);
                }
            }
            else
            {
                List<string> list = new List<string>();
                list.Add(DoorName);
                this.internalDictionary.Add(BadgeID, list);
            }
        }

       public Dictionary<int, List<string>> GetContents(int BadgeID, string DoorName)
        {
            return this.internalDictionary;
        }

        public void Edit(int BadgeID, string DoorName)
        {
            return this.internalDictionary;
        }
    }
}

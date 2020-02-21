using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCafe_Repo
{
        public class MenuContent
        {
            public string MealName { get; set; }
            public int MealNumber { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
            public List<string> Ingredients { get; set; }

            public MenuContent() { }
            public MenuContent(string mealName, int mealNumber, string description, int price, List<string> ingredients)
            {
                MealName = mealName;
                MealNumber = mealNumber;
                Description = description;
                Price = price;
                Ingredients = ingredients;
            }
        }
    
}

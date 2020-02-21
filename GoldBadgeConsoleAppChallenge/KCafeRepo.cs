﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCafe_Repo
{

    public class KCafeRepo
    {
        public List<MenuContent> _contentDirectory = new List<MenuContent>();
        public bool AddContentToDirectory(MenuContent content)
        {
            int directoryLength = _contentDirectory.Count();
            _contentDirectory.Add(content);
            bool wasAdded = directoryLength + 1 == _contentDirectory.Count();
            return wasAdded;
        }
        public List<MenuContent> GetContents()
        {
            return _contentDirectory;
        }
        public MenuContent GetContentByNumber(int mealNumber)
        { 
            foreach (MenuContent content in _contentDirectory)
            {
                if (content.MealNumber == mealNumber)
                {
                    return content;
                }
            }
            return null;
        }
        public bool DeleteExistingConsistent(int mealNumber)
        {
            MenuContent foundContent = GetContentByNumber(mealNumber); //we're getting a MenuContent object
            bool deletedResult = _contentDirectory.Remove(foundContent); //now were deleting it
            return deletedResult;
        }
    }
}


/*The Menu Items:
A meal number, so customers can say "I'll have the #5"
A meal name
A description
A list of ingredients,
A price
Your Task:
Create a Menu Class with properties, constructors, and fields. -
Create a MenuRepository Class that has methods needed. - 
Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list.*/  

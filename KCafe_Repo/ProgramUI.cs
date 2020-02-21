using KCafe_Repo;
using System;
using System.Collections.Generic;

namespace KCafe_Console
{
    public class ShowContents
    {
        public KCafeRepo _Repo = new KCafeRepo();
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Select an option number:\n" +
                    "1. View menu\n" +
                    "2. Add item to the menu\n" +
                    "3. Remove item from the menu\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                userInput = userInput.Replace(" ", "");
                switch (userInput)
                {
                    case "1":
                        //Show All Content
                        GetContents();
                        Console.ReadKey();
                        break;
                    case "2":
                        AddContentToDirectory();
                        break;
                    case "3":
                        DeleteExistingConsistent();
                        break;
                    case "4":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }


        private void GetContents()
        {
            List<MenuContent> listOfContents = _Repo.GetContents();
            foreach (MenuContent content in listOfContents)
            {
                Console.WriteLine($"Meal Name: {content.MealName}\n" +
                    $"Number: {content.MealNumber}\n" +
                    $"Description: {content.Description}\n" +
                    $"Price: ${content.Price}\n" +
                    $"Ingredients: {content.Ingredients}");
            }
        }

            private void AddContentToDirectory()
            {
                MenuContent contents = new MenuContent();
                Console.WriteLine("Hello there, please enter a meal name.");
                contents.MealName = Console.ReadLine();

                Console.WriteLine("What is the meal number?");
                contents.MealNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a Description");
                contents.Description = Console.ReadLine();

                Console.WriteLine("What is the Price?");
                contents.Price = Convert.ToInt32(Console.ReadLine());

                _Repo.AddContentToDirectory(contents);
                Console.WriteLine("Your content has been added! Press any key to return to the main menu");
                Console.ReadKey();
            }
        
            public void DeleteExistingConsistent()
            {
                GetContents();
                Console.WriteLine("Please enter meal number to remove item from the system");
                int mealNumber = Convert.ToInt32(Console.ReadLine());

                _Repo.DeleteExistingConsistent(mealNumber);
            }


        
    }
}



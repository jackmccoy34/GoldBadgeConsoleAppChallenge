using Content_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents_Repo
{

    class MainUI
    {
        public BadgeRepo _Repo = new BadgeRepo();
        public void Run()
        {
            RunMenu();
        }
        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Select an option number:\n" +
                    "1. Add a Badge\n" +
                    "2. Edit a Badge\n" +
                    "3. Show all Badges\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                userInput = userInput.Replace(" ", "");
                switch (userInput)
                {
                    case "1":
                        AddContent();
                        Console.ReadKey();
                        break;
                    case "2":
                        EditContent();
                        break;
                    case "3":
                        GetContent();
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
        public void AddContent()
        {
            BadgeClass content = new BadgeClass(' ', " ");
            Console.WriteLine("What is the number on the Badge?");
            content.BadgeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("List a door that it needs access to:");
            content.DoorName = Console.ReadLine();

            Console.WriteLine("Any other doors?(y/n)");
            string userInput = Console.ReadLine();
            if (userInput.Contains("y"))
            {
                Console.WriteLine("List a door that it needs access to:");
                content.DoorName = Console.ReadLine();
            }
            else
            {
                RunMenu();
            }

            _Repo.Add(' ', " ");
            Console.WriteLine("Your content has been added! Press any key to return to the main menu");
            Console.ReadKey();

        }



        public void EditContent()
        {

        }




        public void GetContent()
        {
            Console.Clear();
            Dictionary<int, List<string>> internalDictionary = _Repo.GetContents(' ', " ");
            
            foreach (BadgeClass content in internalDictionary)                                       //
            {
                Console.WriteLine($"Badge Number: {content.BadgeID}\n" +
                    $"Door Access: {content.DoorName}\n");
            }
        }

    }
}

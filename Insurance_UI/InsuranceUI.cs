using Insurance_Repo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Insurance_UI
{
    public class InsuranceUI
    {
        private readonly InsuranceRepo _Repo = new InsuranceRepo();
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

                Console.WriteLine("Select an option number: (There is no seed content, please enter a new claim to view or take care of)\n" +
                    "1. View claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim\n" +
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
                        DeleteLastContent();
                        break;
                    case "3":
                        AddNewContent();
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
            Console.Clear();
            Queue<ClaimContents> listOfContents = _Repo.GetContents();
            foreach (ClaimContents content in listOfContents)
            {
                Console.WriteLine($"Claim ID: {content.ID}\n" +
                    $"Claim Type: {content.TypeOfClaim}\n" +
                    $"Description: {content.Description}\n" +
                    $"Price: ${content.ClaimAmount}\n" +
                    $"Date of Incident: {content.DateOfIncident}\n" +
                    $"Date of Claim: {content.DateOfClaim}\n" +
                    $"Is Claim Valid? {content.IsValid}");
            }
        }

        private void DeleteLastContent()
        {

            ClaimContents peek = _Repo.PeekContent();
            //We want to view the details of the next claim in the queue, we do that with the queue.Peek() method
            Console.WriteLine("Would you like to deal with this claim now(y/n)?)");
            string userInput = Console.ReadLine();
            if (userInput.Contains("y"))
            {
                _Repo.GetLastContent();
            }
            else
            {
                Console.WriteLine("The claim will be handled later");
                Console.ReadKey();
            }


            //take some input from the user, write a conditional to evaluate their input
            //Call our dequeue method to "take care of" that claim
        }

        private void AddNewContent()
        {
            ClaimContents content = new ClaimContents();
            Console.WriteLine("Hello there, please enter a claim ID.");
            content.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the claim type?\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3.Theft");

            string TypeOfClaim = Console.ReadLine();

            Console.WriteLine("Enter a Description");
            content.Description = Console.ReadLine();

            Console.WriteLine("What is the Claim Amount?");
            content.ClaimAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What date did the incident occur on?");
            content.DateOfIncident = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("What date was the claim?");
            content.DateOfClaim = Convert.ToDateTime(Console.ReadLine());

            _Repo.AddContentToDirectory(content);
            Console.WriteLine("Your content has been added! Press any key to return to the main menu");
            Console.ReadKey();

        }

      
    }
}
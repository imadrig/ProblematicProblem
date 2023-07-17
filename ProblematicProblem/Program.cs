using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        static Random rng = new Random();

        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
        {
            bool redoActivity = true;

            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            bool cont;

            if (userInput == "yes" || userInput == "y")
            {
                cont = true;
            }
            else
            {
                cont = false;
                Console.WriteLine("Come back whenever you're ready!");
                return;
            }

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();


                Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                string userInputList = Console.ReadLine();
                userInputList = userInputList.ToLower();

                bool seeList;

                if (userInputList == "sure" || userInputList == "yes" || userInputList == "y")
                {
                    seeList = true;
                }
                else
                {
                    seeList = false;
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    string userAddActivity = Console.ReadLine();
                    bool addToList;
                    if (userAddActivity == "yes" || userAddActivity == "y")
                    {
                        addToList = true;
                    }
                    else
                    {
                        addToList = false;
                    }

                    Console.WriteLine();

                    while (addToList)
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();
                        activities.Add(userAddition);
                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add more? yes/no: ");
                        string userMoreActivities = Console.ReadLine();
                        userMoreActivities = userMoreActivities.ToLower();

                        if (userMoreActivities == "yes" || userMoreActivities == "y")
                        {
                            addToList = true;
                        }
                        else
                        {
                            addToList = false;

                        }

                    }
                }

                if (seeList)
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();

                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    string userAddActivity = Console.ReadLine();
                    bool addToList;
                    if (userAddActivity == "yes" || userAddActivity == "y")
                    {
                        addToList = true;
                    }
                    else
                    {
                        addToList = false;
                    }


                    Console.WriteLine();

                    while (addToList)
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();
                        activities.Add(userAddition);

                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                        Console.WriteLine();

                        Console.WriteLine("Would you like to add more? yes/no: ");


                    }
                }

                while (cont)
                {
                    Console.Write("Connecting to the database");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    Console.Write("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();

                    int randomNumber = rng.Next(activities.Count);
                    string randomActivity = activities[randomNumber];

                    if (userAge < 21 && randomActivity == "Wine Tasting")
                    {

                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randomActivity);
                        randomNumber = rng.Next(activities.Count);
                        randomActivity = activities[randomNumber];
                    }
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity} ! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                    string userOkayForActivity = Console.ReadLine();
                    userOkayForActivity = userOkayForActivity.ToLower();


                    if (userOkayForActivity == "keep")
                    {
                        redoActivity = true;
                        Console.WriteLine("Enjoy your activity!");
                        break;
                    }
                    else if (userOkayForActivity == "redo")
                    {
                        Console.WriteLine("Ok, lelt's start again.");
                        redoActivity = false;


                    }
                    else
                    {
                        Console.WriteLine("Please try again.");
                    }
                
            }
        }
    }
}
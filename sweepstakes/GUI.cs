using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    static class GUI
    {
        public static string[,] infoScreen;
        public static string[,] contestantInfo;
        public static string[,] createSweepstakeMenu;
        public static void ContestantInfoScreen(int phase)
        {
            Console.Clear();
            if (phase == 1)
            {
                infoScreen = new string[,]
                {
                    { "|-------------------------------------------|" },
                    { "  Plese Enter your first name:" },
                    { "|-------------------------------------------|" }
                };
                foreach (var item in infoScreen)
                {
                    Console.WriteLine(item);
                }
            }
            else if (phase == 2)
            {
                infoScreen = new string[,]
                {
                    { "|-------------------------------------------|" },
                    { "  Plese Enter your first name:" },
                    { "  Plese Enter your last name:" },
                    { "|-------------------------------------------|" }
                };
                foreach (var item in infoScreen)
                {
                    Console.WriteLine(item);
                }
            }
            else if (phase == 3)
            {
                infoScreen = new string[,]
                {
                    { "|-------------------------------------------|" },
                    { "  Plese Enter your first name:" },
                    { "  Plese Enter your last name:" },
                    { "  Plese Enter your email address:" },
                    { "|-------------------------------------------|" }
                };
                foreach (var item in infoScreen)
                {
                    Console.WriteLine(item);
                }
            }
            else if (phase == 4)
            {
                infoScreen = new string[,]
                {
                    { "|-------------------------------------------|" },
                    { "         Thank you for registering!          " },
                    { "|-------------------------------------------|" }
                };
                foreach (var item in infoScreen)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void DisplayContestantInfo(Contestant contestant)
        {
            Console.Clear();
            contestantInfo = new string[,]
            {
                { "|-------------------------------------------|" },
                { "  Viewing Contestant: " + contestant.registrationNumber},
                { " " },
                { "        First Name: " + contestant.FirstName},
                { "        Last Name: " + contestant.LastName},
                { "        Email Address: " + contestant.EmailAddress},
                { "|-------------------------------------------|" }
            };
            foreach (var item in contestantInfo)
            {
                Console.WriteLine(item);
            }
        }
        public static void CreateSweepstakeMenu()
        {
            Console.Clear();
            createSweepstakeMenu = new string[,]
            {
                { " _____________________________________________________ " },
                { "|-----------------------------------------------------|" },
                { "|  Please enter in the name of your new sweepstakes:  |" },
                { "|_____________________________________________________|" }
            };
            foreach (var item in createSweepstakeMenu)
            {
                Console.WriteLine(item);
            }
        }
    }
}

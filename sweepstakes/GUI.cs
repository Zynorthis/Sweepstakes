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
        public static string[,] sweepstakesSetupMenu;
        public static string[,] preWinnerPickQuestion;
        public static string[,] getRegistrationNumberMenu;
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
        public static void CreateSweepstakeMenu(int phase)
        {
            if (phase == 1)
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
            else if (phase == 2)
            {
                Console.Clear();
                createSweepstakeMenu = new string[,]
                {
                { " _____________________________________________________ " },
                { "|-----------------------------------------------------|" },
                { "| Please enter in the email for your new sweepstakes: |" },
                { "|_____________________________________________________|" }
                };
                foreach (var item in createSweepstakeMenu)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void SweepstakesSetup()
        {
            Console.Clear();
            sweepstakesSetupMenu = new string[,]
            {
                { " _____________________________________________________ " },
                { "|-----------------------------------------------------|" },
                { "|      How many contestant need to be entered?        |" },
                { "|_____________________________________________________|" }
            };
            foreach (var item in sweepstakesSetupMenu)
            {
                Console.WriteLine(item);
            }
        }
        public static void PreWinnerPromp()
        {
            Console.Clear();
            preWinnerPickQuestion = new string[,]
            {
                { " _____________________________________________________ " },
                { "|-----------------------------------------------------|" },
                { "|  Would you like to view any contestant information? |" },
                { "|_____________________________________________________|" }
            };
            foreach (var item in preWinnerPickQuestion)
            {
                Console.WriteLine(item);
            }
        }
        public static void GetRegistrationNumber()
        {
            Console.Clear();
            getRegistrationNumberMenu = new string[,]
            {
                { " _____________________________________________________ " },
                { "|-----------------------------------------------------|" },
                { "|     Please enter contestant registration number.    |" },
                { "|_____________________________________________________|" }
            };
            foreach (var item in getRegistrationNumberMenu)
            {
                Console.WriteLine(item);
            }
        }
        public static void DisplaySuccess(string part1, string part2)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(part1 + part2);
            Console.ResetColor();
            Console.ReadKey();
        }
        public static void DisplaySuccess(string part1)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(part1);
            Console.ResetColor();
            // Console.ReadKey();
        }
        public static void DisplayError(string errorMessage)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}

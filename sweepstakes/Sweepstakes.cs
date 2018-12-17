using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Sweepstakes
    {
        // member variables
        public Dictionary<int, Contestant> contestantDictonary = new Dictionary<int, Contestant>();
        private string name;
        public string Name { get { return name; } private set { name = value; } }

        // member methods
        public Sweepstakes(string name)
        {
            this.Name = name;
        }

        public void RunSweepstakes()
        {
            SweepstakesSetup();
            PreWinnerPrompt();

        }
        private void SweepstakesSetup()
        {
            GUI.SweepstakesSetup();
            int numberOfContestants = Int32.Parse(Console.ReadLine());
            int i = 0;
            while (i < numberOfContestants)
            {
                EnterContestantInfo();
            }
        }
        private void PreWinnerPrompt()
        {
            GUI.PreWinnerPromp();
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                GUI.GetRegistrationNumber();
                int contestantRegistrationNumber = Int32.Parse(Console.ReadLine());
                Contestant contestant = new Contestant();
                contestant = contestantDictonary[contestantRegistrationNumber];
                PrintContestantInfo(contestant);
                PreWinnerPrompt();
            }
            else if (answer == "no")
            {
                Contestant winnerWinnerChickenDinner = PickWinner();
                Console.WriteLine(winnerWinnerChickenDinner.FirstName + " " + winnerWinnerChickenDinner.LastName + " is the sweepstake winner!");
                Console.ReadKey();
            }
            else
            {
                string error = "Error: Invalid input, please try again.";
                GUI.DisplayError(error);
            }
        }
        public void EnterContestantInfo()
        {
            Contestant contestant = new Contestant();
            GUI.ContestantInfoScreen(1);
            contestant.FirstName = Console.ReadLine();
            GUI.ContestantInfoScreen(2);
            contestant.LastName = Console.ReadLine();
            GUI.ContestantInfoScreen(3);
            contestant.EmailAddress = Console.ReadLine();
            GUI.ContestantInfoScreen(4);
            RegisterContestant(contestant);
        }
        private void RegisterContestant(Contestant contestant)
        {
            // begins key generation
            Random newKey = new Random();
            int key = newKey.Next(10000, 99999);

            contestant.registrationNumber = key;
            contestantDictonary.Add(key, contestant);
        }
        private Contestant PickWinner()
        {
            Random winningNumber = new Random();
            Contestant winningContestant = new Contestant();
            bool isWinnerPicked = false;
            while (isWinnerPicked == false)
            {
                int winner = winningNumber.Next(10000, 99999);
                System.Threading.Thread.Sleep(20);
                try
                {
                    winningContestant = contestantDictonary[winner];
                    isWinnerPicked = true;
                }
                catch
                {
                    Console.WriteLine("Key = " + winner + ": was not found in dictonary. Re-rolling...");
                    isWinnerPicked = false;
                }
            }
            // string winnerWinnerChickenDinner = winningContestant.FirstName + " " + winningContestant.LastName;
            return winningContestant;
        }
        private void PrintContestantInfo(Contestant contestant)
        {
            GUI.DisplayContestantInfo(contestant);
            Console.ReadKey();
        }
    }
}

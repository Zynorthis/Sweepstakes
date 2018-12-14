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
        Dictionary<int, Contestant> contestantDictonary = new Dictionary<int, Contestant>();
        private string name;
        public string Name { get { return name; } private set { name = value; } }

        // member methods
        public Sweepstakes(string name)
        {
            this.Name = name;
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
        public void RegisterContestant(Contestant contestant)
        {
            // begins key generation
            Random newKey = new Random();
            int key = newKey.Next(10000, 99999);

            contestant.registrationNumber = key;
            contestantDictonary.Add(contestant.registrationNumber, contestant);
        }
        private string PickWinner()
        {
            Random winningNumber = new Random();
            Contestant winningContestant = new Contestant();
            bool isWinnerPicked = false;
            while (isWinnerPicked == false)
            {
                int winner = winningNumber.Next(10000, 99999);
                try
                {
                    winningContestant = contestantDictonary[winner];
                    isWinnerPicked = true;
                }
                catch
                {
                    Console.WriteLine("Key = " + winner + " was not found in dictonary.");
                    isWinnerPicked = false;
                }
            }
            string winnerWinnerChickenDinner = winningContestant.FirstName + " " + winningContestant.LastName;
            return winnerWinnerChickenDinner;
        }
        private void PrintContestantInfo(Contestant contestant)
        {
            GUI.DisplayContestantInfo(contestant);
            Console.ReadKey();
        }
    }
    internal interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
    }
}

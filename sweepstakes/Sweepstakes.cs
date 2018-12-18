using MimeKit;
using MailKit.Net.Smtp;
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
        private MailboxAddress email;
        public MailboxAddress Email { get { return email; } private set { email = value; } }
        public int numberOfContestants;

        // member methods
        public Sweepstakes(string name, MailboxAddress email)
        {
            this.Name = name;
            this.Email = email;
        }

        public void RunSweepstakes()
        {
            SweepstakesSetup();
            PreWinnerPrompt();

        }
        private void SweepstakesSetup()
        {
            GUI.SweepstakesSetup();
            numberOfContestants = Int32.Parse(Console.ReadLine());
            int i = 0;
            while (i < numberOfContestants)
            {
                EnterContestantInfo();
                i++;
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
                // string winner = PickWinner();
                string winner = "Jacob Taylor";
                Console.WriteLine(winner + " is the sweepstake winner!");
                Console.ReadKey();
                Console.WriteLine("Sending emails...");
                SendEmails(contestantDictonary, winner);
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
        private string PickWinner()
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
            string winnerWinnerChickenDinner = winningContestant.FirstName + " " + winningContestant.LastName;
            return winnerWinnerChickenDinner;
        }
        private void PrintContestantInfo(Contestant contestant)
        {
            GUI.DisplayContestantInfo(contestant);
            Console.ReadKey();
        }
        private void SendEmails(Dictionary<int, Contestant> dictionary, string winner)
        {
            var winnerEmails = new MimeMessage();
            winnerEmails.From.Add(Email);
            //for (int i = 1; i <= dictionary.Count(); i++)
            //{
            //    winnerEmails.To.Add(MailboxAddress.Parse(dictionary.ElementAt(i).Value.EmailAddress));
            //}
            foreach(var thing in dictionary)
            {
                winnerEmails.To.Add(MailboxAddress.Parse(thing.Value.EmailAddress));
            }
            winnerEmails.Subject = "Sweepstakes Winner!";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "A winner has been selected! congrats to " + winner + ".";
            winnerEmails.Body = bodyBuilder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.yahoo.com", 465, true);
            smtpClient.AuthenticationMechanisms.Remove("XOAUTH2");
            smtpClient.Authenticate("githubmailbot@yahoo.com", "!NotaPassword001");
            smtpClient.Send(winnerEmails);
            smtpClient.Disconnect(true);
        }
    }
}

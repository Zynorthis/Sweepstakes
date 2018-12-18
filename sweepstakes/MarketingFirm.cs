using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class MarketingFirm
    {
        Sweepstakes currentSelection;
        ISweepstakesManager sweepstakesManager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.sweepstakesManager = manager;
        }

        public void CreateSweepstake()
        {
            GUI.CreateSweepstakeMenu(1);
            string sweepstakesName = Console.ReadLine();
            GUI.CreateSweepstakeMenu(2);
            MailboxAddress sweepstakesEmail = MailboxAddress.Parse(Console.ReadLine());
            Sweepstakes newSweepstake = new Sweepstakes(sweepstakesName, sweepstakesEmail);

            try
            {
                sweepstakesManager.InsertSweepstakes(newSweepstake);

                string messagePart1 = newSweepstake.Name;
                string messagePart2 = " has been added to successfully!";
                GUI.DisplaySuccess(messagePart1, messagePart2);
            }
            catch
            {
                string error = "Error: could not add sweepstake to stack/queue.";
                GUI.DisplayError(error);
            }
        }
        public void RunSweepstake()
        {
            currentSelection = sweepstakesManager.GetSweepstakes();
            currentSelection.RunSweepstakes();
        }
    }
}

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
        List<Sweepstakes> sweepstakesList = new List<Sweepstakes>();
        ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        private void CreateSweepstake()
        {
            GUI.CreateSweepstakeMenu();
            string sweepstakesName = Console.ReadLine();
            Sweepstakes newSweepstake = new Sweepstakes(sweepstakesName);
            try
            {
                sweepstakesList.Add(newSweepstake);

                string messagePart1 = newSweepstake.Name;
                string messagePart2 = " has been added to successfully!";
                GUI.DisplaySuccess(messagePart1, messagePart2);
            }
            catch
            {
                string error = "Error: could not setup add sweepstake to list.";
                GUI.DisplayError(error);
            }
        }
        private void SweepstakeSelector()
        {

            string sweepstakesName = Console.ReadLine();
            bool isSweepstakeFound = false;
            int i = 0;
            while (isSweepstakeFound = false && i < sweepstakesList.Count)
            {
                if (sweepstakesName == sweepstakesList[i].Name)
                {
                    currentSelection = sweepstakesList[i];
                    isSweepstakeFound = true;
                }
                else
                {
                    i++;
                    isSweepstakeFound = false;
                }
            }
            if (isSweepstakeFound == false)
            {
                string error = "Sweepstake was not found in the current list of sweepstakes.";
                GUI.DisplayError(error);
            }
            else if (isSweepstakeFound == true)
            {
                string messagePart1 = currentSelection.Name;
                string messagePart2 = " has been selected!";
                GUI.DisplaySuccess(messagePart1, messagePart2);
            }
        }
    }
}

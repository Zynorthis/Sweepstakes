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
        ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public Sweepstakes CreateSweepstake()
        {
            GUI.CreateSweepstakeMenu();
            string sweepstakesName = Console.ReadLine();
            Sweepstakes newSweepstake = new Sweepstakes(sweepstakesName);
            return newSweepstake;
        }
    }
}

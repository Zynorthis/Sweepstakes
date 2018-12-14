using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesStakeManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> sweepstakesManager = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesManager.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesManager.Pop();
        }
    }
}
